namespace FManagerApp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftDrivesPanel = new System.Windows.Forms.Panel();
            this.LeftListView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftPathTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightListView = new System.Windows.Forms.ListView();
            this.NameHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightPathTextBox = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightDrivesPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LeftPanel.Controls.Add(this.LeftDrivesPanel);
            this.LeftPanel.Controls.Add(this.LeftListView);
            this.LeftPanel.Controls.Add(this.LeftPathTextBox);
            this.LeftPanel.Location = new System.Drawing.Point(12, 33);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(456, 495);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftDrivesPanel
            // 
            this.LeftDrivesPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftDrivesPanel.Name = "LeftDrivesPanel";
            this.LeftDrivesPanel.Size = new System.Drawing.Size(456, 33);
            this.LeftDrivesPanel.TabIndex = 6;
            // 
            // LeftListView
            // 
            this.LeftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.TypeHeader,
            this.SizeHeader,
            this.DateHeader});
            this.LeftListView.Location = new System.Drawing.Point(3, 60);
            this.LeftListView.Name = "LeftListView";
            this.LeftListView.Size = new System.Drawing.Size(448, 432);
            this.LeftListView.TabIndex = 5;
            this.LeftListView.UseCompatibleStateImageBehavior = false;
            this.LeftListView.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Имя";
            this.NameHeader.Width = 130;
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Тип";
            this.TypeHeader.Width = 66;
            // 
            // SizeHeader
            // 
            this.SizeHeader.Text = "Размер";
            this.SizeHeader.Width = 76;
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Дата";
            this.DateHeader.Width = 172;
            // 
            // LeftPathTextBox
            // 
            this.LeftPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPathTextBox.Location = new System.Drawing.Point(3, 33);
            this.LeftPathTextBox.Name = "LeftPathTextBox";
            this.LeftPathTextBox.Size = new System.Drawing.Size(448, 20);
            this.LeftPathTextBox.TabIndex = 1;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(3, 17);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(181, 23);
            this.ShowButton.TabIndex = 2;
            this.ShowButton.Text = "Просмотр";
            this.ShowButton.UseVisualStyleBackColor = true;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(187, 17);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(181, 23);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Копирование";
            this.CopyButton.UseVisualStyleBackColor = true;
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(374, 17);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(181, 23);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.Text = "Перемещение";
            this.MoveButton.UseVisualStyleBackColor = true;
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(561, 17);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(181, 23);
            this.RenameButton.TabIndex = 5;
            this.RenameButton.Text = "Переименование";
            this.RenameButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(748, 17);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(181, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удаление";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RightPanel.Controls.Add(this.RightListView);
            this.RightPanel.Controls.Add(this.RightPathTextBox);
            this.RightPanel.Location = new System.Drawing.Point(484, 33);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(457, 495);
            this.RightPanel.TabIndex = 7;
            // 
            // RightListView
            // 
            this.RightListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader1,
            this.TypeHeader2,
            this.SizeHeader3,
            this.DateHeader4});
            this.RightListView.Location = new System.Drawing.Point(3, 59);
            this.RightListView.Name = "RightListView";
            this.RightListView.Size = new System.Drawing.Size(449, 432);
            this.RightListView.TabIndex = 7;
            this.RightListView.UseCompatibleStateImageBehavior = false;
            this.RightListView.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader1
            // 
            this.NameHeader1.Text = "Имя";
            this.NameHeader1.Width = 130;
            // 
            // TypeHeader2
            // 
            this.TypeHeader2.Text = "Тип";
            this.TypeHeader2.Width = 66;
            // 
            // SizeHeader3
            // 
            this.SizeHeader3.Text = "Размер";
            this.SizeHeader3.Width = 76;
            // 
            // DateHeader4
            // 
            this.DateHeader4.Text = "Дата";
            this.DateHeader4.Width = 172;
            // 
            // RightPathTextBox
            // 
            this.RightPathTextBox.Location = new System.Drawing.Point(3, 33);
            this.RightPathTextBox.Name = "RightPathTextBox";
            this.RightPathTextBox.Size = new System.Drawing.Size(449, 20);
            this.RightPathTextBox.TabIndex = 2;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.AutoSize = true;
            this.BottomPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BottomPanel.Controls.Add(this.ShowButton);
            this.BottomPanel.Controls.Add(this.DeleteButton);
            this.BottomPanel.Controls.Add(this.CopyButton);
            this.BottomPanel.Controls.Add(this.RenameButton);
            this.BottomPanel.Controls.Add(this.MoveButton);
            this.BottomPanel.Location = new System.Drawing.Point(12, 539);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(932, 43);
            this.BottomPanel.TabIndex = 8;
            // 
            // RightDrivesPanel
            // 
            this.RightDrivesPanel.Location = new System.Drawing.Point(484, 33);
            this.RightDrivesPanel.Name = "RightDrivesPanel";
            this.RightDrivesPanel.Size = new System.Drawing.Size(457, 33);
            this.RightDrivesPanel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(954, 594);
            this.Controls.Add(this.RightDrivesPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BottomPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.TextBox LeftPathTextBox;
        private System.Windows.Forms.TextBox RightPathTextBox;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ListView LeftListView;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader TypeHeader;
        private System.Windows.Forms.ColumnHeader SizeHeader;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.ListView RightListView;
        private System.Windows.Forms.ColumnHeader NameHeader1;
        private System.Windows.Forms.ColumnHeader TypeHeader2;
        private System.Windows.Forms.ColumnHeader SizeHeader3;
        private System.Windows.Forms.ColumnHeader DateHeader4;
        private System.Windows.Forms.Panel LeftDrivesPanel;
        private System.Windows.Forms.Panel RightDrivesPanel;
    }
}

