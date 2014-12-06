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

namespace FManagerApp
{
    public partial class Form1 : Form
    {
        private List<Button> LeftLogicalDrives = new List<Button>();
        private List<Button> RightLogicalDrives = new List<Button>();

        private string LeftViewRootPath = "C:\\";
        private string RightViewRootPath = "C:\\";

        private FileSystemWatcher LeftViewObserver = new FileSystemWatcher();
        private FileSystemWatcher RightViewObserver = new FileSystemWatcher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            UpdateDrivesPanel();
            ConfigurateObservers();
            UpdateListView(LeftListView, LeftViewRootPath);
            LeftPathTextBox.Text = LeftViewRootPath;
            RightPathTextBox.Text = RightViewRootPath;
            UpdateListView(RightListView, RightViewRootPath);
        }

        //обновляет информацию на панели вывода существующих дисков
        private void UpdateDrivesPanel()
        {
            LeftDrivesPanel.SuspendLayout();
            RightDrivesPanel.SuspendLayout();

            //чистим предыдущее состояние
            foreach (Button btn in LeftLogicalDrives)
                LeftDrivesPanel.Controls.Remove(btn);
            foreach (Button btn in RightLogicalDrives)
                RightDrivesPanel.Controls.Remove(btn);
            LeftLogicalDrives.Clear();
            RightLogicalDrives.Clear();

            //загружаем новое
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivesInfo)
            {
                if (drive.DriveType != DriveType.Fixed && drive.DriveType != DriveType.Removable) return;
                Button driveBtnLeft = new Button();
                Button driveBtnRight = new Button();
                LeftDrivesPanel.Controls.Add(driveBtnLeft);
                RightDrivesPanel.Controls.Add(driveBtnRight);

                driveBtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                driveBtnLeft.Size = new System.Drawing.Size(37, 28);
                driveBtnLeft.Location = new System.Drawing.Point(3 + LeftLogicalDrives.Count * (driveBtnLeft.Size.Width + 5), 3);
                driveBtnLeft.Text = drive.Name[0].ToString();
                driveBtnLeft.Name = driveBtnLeft.Text + "button";
                driveBtnLeft.TabIndex = LeftLogicalDrives.Count;
                driveBtnLeft.UseVisualStyleBackColor = true;
                driveBtnLeft.Click += new System.EventHandler(ChangeDriveButton_Click);

                driveBtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                driveBtnRight.Size = new System.Drawing.Size(37, 28);
                driveBtnRight.Location = new System.Drawing.Point(3 + RightLogicalDrives.Count * (driveBtnRight.Size.Width + 5), 3);
                driveBtnRight.Text = drive.Name[0].ToString();
                driveBtnRight.Name = driveBtnRight.Text + "button";
                driveBtnRight.TabIndex = RightLogicalDrives.Count;
                driveBtnRight.UseVisualStyleBackColor = true;
                driveBtnRight.Click += new System.EventHandler(ChangeDriveButton_Click);

                LeftLogicalDrives.Add(driveBtnLeft);
                RightLogicalDrives.Add(driveBtnRight);
            }

            LeftDrivesPanel.ResumeLayout();
            RightDrivesPanel.ResumeLayout();
        }

        private void UpdateListView(ListView listView, string root)
        {
            listView.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(root);
            try
            {
                var files = dirInfo.GetFiles();
                var folders = dirInfo.GetDirectories();

                if (dirInfo.Parent != null)
                    listView.Items.Add(BuildListViewItem(
                        "...",
                        "",
                        "",
                        ""
                    ));

                foreach (DirectoryInfo folder in folders)
                {
                    listView.Items.Add(BuildListViewItem(
                        System.IO.Path.GetFileName(folder.FullName),
                        "",
                        "<папка>",
                        folder.CreationTime.ToShortDateString() + " " + folder.CreationTime.ToShortTimeString()
                    ));
                }

                foreach (FileInfo file in files)
                {
                    string ext = (file.Extension.Length > 0) ? file.Extension.Substring(1) : "";
                    listView.Items.Add(BuildListViewItem(
                        System.IO.Path.GetFileNameWithoutExtension(file.FullName),
                        ext,
                        GetSize(file.Length),
                        file.CreationTime.ToShortDateString() + " " + file.CreationTime.ToShortTimeString()
                    ));
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Устройство не готово!");
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("Отказано в доступе!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        //Построение объекта ListViewItem для ListView в программе
        private ListViewItem BuildListViewItem(string itemName, string type, string size, string date)
        {
            ListViewItem item = new ListViewItem(itemName);
            item.SubItems.Add(type);
            item.SubItems.Add(size);
            item.SubItems.Add(date);
            return item;
        }

        // Форматируем размер файла из числа байт в необходимые единицы измерения
        private string GetSize(long size)
        {
            double bytes = size;
            double kBytes = Math.Round(bytes/1024,1);
            double mBytes = Math.Round(kBytes/1024,1);
            double gBytes = Math.Round(mBytes/1024,1);

            if (gBytes >= 1)
                return String.Format("{0} Гб", gBytes);
            else if (mBytes >= 1)
                return String.Format("{0} Мб", mBytes);
            else if (kBytes >= 1)
                return String.Format("{0} Кб", kBytes);
            else return String.Format("{0} байт", bytes);
        }

        private delegate void Del(object source, FileSystemEventArgs e);
        // инициализируем обозреватели
        private void ConfigurateObservers()
        {
            Del leftOnChanded = delegate(object source, FileSystemEventArgs e){UpdateListView(LeftListView, LeftViewRootPath);};
            Del rightOnChanded = delegate(object source, FileSystemEventArgs e) { UpdateListView(RightListView, RightViewRootPath); };

            // для левой панели
            LeftViewObserver.Path = LeftViewRootPath;
            LeftViewObserver.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            LeftViewObserver.Changed += new FileSystemEventHandler(leftOnChanded);
            LeftViewObserver.Created += new FileSystemEventHandler(leftOnChanded);
            LeftViewObserver.Deleted += new FileSystemEventHandler(leftOnChanded);
            LeftViewObserver.Renamed += new RenamedEventHandler(leftOnChanded);
            LeftViewObserver.SynchronizingObject = LeftListView;
            LeftViewObserver.EnableRaisingEvents = true;


            // для правой панели
            RightViewObserver.Path = RightViewRootPath;
            RightViewObserver.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            RightViewObserver.Changed += new FileSystemEventHandler(rightOnChanded);
            RightViewObserver.Created += new FileSystemEventHandler(rightOnChanded);
            RightViewObserver.Deleted += new FileSystemEventHandler(rightOnChanded);
            RightViewObserver.Renamed += new RenamedEventHandler(rightOnChanded);
            RightViewObserver.SynchronizingObject = RightListView;
            RightViewObserver.EnableRaisingEvents = true;
        }

        private void ChangeDriveButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (LeftPanel.Contains(button))
            {
                //данная кнопка принадлежит левой панели
                LeftViewRootPath = button.Text + ":\\";
                LeftPathTextBox.Text = LeftViewRootPath;
                UpdateListView(LeftListView, LeftViewRootPath);
            }
            else
            {
                //данная кнопка принадлежит правой панели
                RightViewRootPath = button.Text + ":\\";
                RightPathTextBox.Text = RightViewRootPath;
                UpdateListView(RightListView, RightViewRootPath);
            }
        }

        private void LeftListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //если выбранный элемент не является папкой или переходом к родительскому каталогу, выходим
            if (!LeftListView.SelectedItems[0].SubItems[2].Text.Equals("<папка>") && !LeftListView.SelectedItems[0].SubItems[0].Text.Equals("...")) return;

            //если выбранный элемент является переходом к родительскому каталогу
            if (LeftListView.SelectedItems[0].SubItems[0].Text.Equals("..."))
            {
                LeftViewRootPath = Directory.GetParent(LeftViewRootPath).FullName;
                LeftPathTextBox.Text = LeftViewRootPath;
                UpdateListView(LeftListView,LeftViewRootPath);
                return;
            }

            if (LeftViewRootPath[LeftViewRootPath.Length - 1] != '\\') LeftViewRootPath += "\\";
            LeftViewRootPath += LeftListView.SelectedItems[0].SubItems[0].Text;
            LeftPathTextBox.Text = LeftViewRootPath;
            UpdateListView(LeftListView, LeftViewRootPath);
        }

        private void RightListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //если выбранный элемент не является папкой или переходом к родительскому каталогу, выходим
            if (!RightListView.SelectedItems[0].SubItems[2].Text.Equals("<папка>") && !RightListView.SelectedItems[0].SubItems[0].Text.Equals("...")) return;

            //если выбранный элемент является переходом к родительскому каталогу
            if (RightListView.SelectedItems[0].SubItems[0].Text.Equals("..."))
            {
                RightViewRootPath = Directory.GetParent(RightViewRootPath).FullName;
                RightPathTextBox.Text = RightViewRootPath;
                UpdateListView(RightListView, RightViewRootPath);
            }
            if (RightViewRootPath[RightViewRootPath.Length - 1] != '\\') RightViewRootPath += "\\";
            RightViewRootPath += RightListView.SelectedItems[0].SubItems[0].Text;
            RightPathTextBox.Text = RightViewRootPath;
            UpdateListView(RightListView, RightViewRootPath);
        }

        private void LeftPathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = sender as TextBox;
                if (Directory.Exists(textBox.Text))
                {
                    LeftViewRootPath = textBox.Text;
                    UpdateListView(LeftListView, LeftViewRootPath);
                }
                else
                {
                    MessageBox.Show("Неверный путь!");
                    textBox.Text = LeftViewRootPath;
                }
            }
        }

        private void RightPathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox textBox = sender as TextBox;
                if (Directory.Exists(textBox.Text))
                {
                    RightViewRootPath = textBox.Text;
                    UpdateListView(RightListView, RightViewRootPath);
                }
                else
                {
                    MessageBox.Show("Неверный путь!");
                    textBox.Text = RightViewRootPath;
                }
            }
        }


    }
}
