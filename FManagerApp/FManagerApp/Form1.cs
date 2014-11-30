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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDrivesPanel();
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

                driveBtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                driveBtnRight.Size = new System.Drawing.Size(37, 28);
                driveBtnRight.Location = new System.Drawing.Point(3 + RightLogicalDrives.Count * (driveBtnRight.Size.Width + 5), 3);
                driveBtnRight.Text = drive.Name[0].ToString();
                driveBtnRight.Name = driveBtnRight.Text + "button";
                driveBtnRight.TabIndex = RightLogicalDrives.Count;
                driveBtnRight.UseVisualStyleBackColor = true;

                LeftLogicalDrives.Add(driveBtnLeft);
                RightLogicalDrives.Add(driveBtnRight);
            }

            LeftDrivesPanel.ResumeLayout();
            RightDrivesPanel.ResumeLayout();
        }

    }
}
