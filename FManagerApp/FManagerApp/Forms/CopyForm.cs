using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FManagerApp.Forms
{
    public partial class CopyForm : Form
    {

        private const int BUFFER_LENGTH = 12228;
        private List<FileSystemInfo> FilesAndDirectories;

        private string Source;

        private string Destination;

        private long TotalSize;

        private long TotalFilesCount;

        private long CopiedFilesCount;

        private long CopiedFilesSize;

        public CopyForm()
        {
            InitializeComponent();
        }

        public void SetParametres(List<FileSystemInfo> filesAndDirs, string source, string destination)
        {
            this.FilesAndDirectories = filesAndDirs;
            this.Source = source;
            this.Destination = destination;
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {
            long filesCount = 0;
            TotalSize = GetAllFilesSize(ref filesCount);
            TotalFilesCount = filesCount;
            CopiedFilesCount = 0;
            CopiedFilesSize = 0;
            allFilesLabel.Text = 0 + "/" + TotalFilesCount;
            sourceLabel.Text = Source;
            destinationLabel.Text = Destination;
            fileNameLabel.Text = "";
            CancelButton.Enabled = false;
        }

        //получение общего размера всех копируемых файлов, и их количества
        private long GetAllFilesSize(ref long filesCount)
        {
            long size = 0;
            try
            {
                foreach (FileSystemInfo fsi in FilesAndDirectories)
                {
                    DirectoryInfo dir = fsi as DirectoryInfo;
                    if (dir != null)
                    {
                        size += GetDirSize(dir, ref filesCount);
                    }
                    else
                    {
                        FileInfo fileInfo = fsi as FileInfo;
                        filesCount++;
                        size += fileInfo.Length;
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Отказано в доступе!");
                this.Close();
            }
            return size;
        }

        //получение размера директории (рекурсивный алгоритм)
        private long GetDirSize(DirectoryInfo directory, ref long filesCount)
        {
            long size = 0;
            DirectoryInfo[] dirs = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();
            if (dirs != null)
            {
                foreach (DirectoryInfo dir in dirs)
                {
                    size += GetDirSize(dir, ref filesCount);
                }
            }

            foreach (FileInfo file in files)
            {
                size += file.Length;
                filesCount++;
            }

            return size;

        }

        private class ProgressState
        {
            public IProgress<int> progressCurrentFile;
            public IProgress<string> currentFileNameProgress;
            public IProgress<int> progressAllFiles;
        }

        private CancellationTokenSource _cts;
        private async void StartButton_Click(object sender, EventArgs e)
        {
            ProgressState progressState = new ProgressState();
            StartButton.Enabled = false;
            CancelButton.Enabled = true;
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            var progressHandlerForCurrentFile = new Progress<int>(value =>
            {
                CurrentFileProgressBar.Value = value;
            });
            progressState.progressCurrentFile = progressHandlerForCurrentFile as IProgress<int>;

            var fileNameProgressHandler = new Progress<string>(value =>
            {
                CopiedFilesCount++;
                fileNameLabel.Text = value;
                allFilesLabel.Text = CopiedFilesCount.ToString() + "/" + TotalFilesCount;
            });
            progressState.currentFileNameProgress = fileNameProgressHandler as IProgress<string>;

            var progressHandlerForAllFiles = new Progress<long>(value =>
            {
                CopiedFilesSize += value;
                double progress = (double)CopiedFilesSize / TotalSize * 100;
                AllFilesProgressBar.Value = (int)Math.Round(progress);
            });
            progressState.progressAllFiles = progressHandlerForAllFiles as IProgress<int>;

            try
            {
                await Task.Run(() =>
                {
                    foreach (FileSystemInfo fsi in FilesAndDirectories)
                    {
                        token.ThrowIfCancellationRequested();
                        DirectoryInfo dir = fsi as DirectoryInfo;
                        if (dir != null)
                        {
                            //копируем директорию
                            CopyDirectory(dir, Destination, progressState);
                        }
                        else
                        {
                            //копируем файл
                            FileInfo fileInfo = fsi as FileInfo;
                            progressState.currentFileNameProgress.Report(fileInfo.Name);
                            fileInfo.CopyTo(Path.Combine(Destination, Path.GetFileName(fileInfo.FullName)), true);
                        }
                    }
                });

                MessageBox.Show("Копирование завершено!");

            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Операция отменена!");
            }
            finally
            {
                this.Dispose();
                this.Close();
            }
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (_cts != null)
                _cts.Cancel();
        }

        private void CopyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cts != null)
                _cts.Cancel();
        }

        private void CopyDirectory(DirectoryInfo sourceDir, string destination, ProgressState progressState)
        {
            string path = Path.Combine(destination, sourceDir.Name);
            if (Directory.Exists(path))
            {
                var result = MessageBox.Show("Директория с таким именем уже существует. Выполнить слияние файлов и папок?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    _cts.Cancel();
                    _cts.Token.ThrowIfCancellationRequested();
                }
            }
            else
            {
                DirectoryInfo destDir = new DirectoryInfo(path);
                destDir.Create();
                foreach (DirectoryInfo dir in sourceDir.GetDirectories())
                {
                    CopyDirectory(dir, destDir.FullName, progressState);
                }

                foreach (FileInfo file in sourceDir.GetFiles())
                {
                    file.CopyTo(Path.Combine(destDir.FullName,Path.GetFileName(file.FullName)),true);
                }
            }

        }

        private void CopyFile(string source, string destination, ProgressState progressState)
        {
            try
            {
                progressState.currentFileNameProgress.Report(Path.GetFileName(source));

                Byte[] streamBuffer = new Byte[BUFFER_LENGTH];

                using (FileStream sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
                {
                    long fileSize = sourceStream.Length;
                    using (FileStream destinationStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
                    {
                        while (true)
                        {
                            int bytesRead = sourceStream.Read(
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка при копировании файла:\n"+e.Message);
                _cts.Cancel();
                _cts.Token.ThrowIfCancellationRequested();
            }

        }




    }
}
