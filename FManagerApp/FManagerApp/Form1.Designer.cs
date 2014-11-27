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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LeftPathTextBox = new System.Windows.Forms.TextBox();
            this.LeftListBox = new System.Windows.Forms.ListBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RightPathTextBox = new System.Windows.Forms.TextBox();
            this.RightListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LeftPanel.Controls.Add(this.button3);
            this.LeftPanel.Controls.Add(this.button2);
            this.LeftPanel.Controls.Add(this.button1);
            this.LeftPanel.Controls.Add(this.LeftPathTextBox);
            this.LeftPanel.Controls.Add(this.LeftListBox);
            this.LeftPanel.Location = new System.Drawing.Point(12, 33);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(456, 495);
            this.LeftPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "E";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "D";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LeftPathTextBox
            // 
            this.LeftPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftPathTextBox.Location = new System.Drawing.Point(3, 33);
            this.LeftPathTextBox.Name = "LeftPathTextBox";
            this.LeftPathTextBox.Size = new System.Drawing.Size(449, 20);
            this.LeftPathTextBox.TabIndex = 1;
            // 
            // LeftListBox
            // 
            this.LeftListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftListBox.FormattingEnabled = true;
            this.LeftListBox.Location = new System.Drawing.Point(3, 59);
            this.LeftListBox.Name = "LeftListBox";
            this.LeftListBox.Size = new System.Drawing.Size(450, 433);
            this.LeftListBox.TabIndex = 0;
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
            this.RightPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RightPanel.Controls.Add(this.button6);
            this.RightPanel.Controls.Add(this.button5);
            this.RightPanel.Controls.Add(this.button4);
            this.RightPanel.Controls.Add(this.RightPathTextBox);
            this.RightPanel.Controls.Add(this.RightListBox);
            this.RightPanel.Location = new System.Drawing.Point(484, 33);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(457, 495);
            this.RightPanel.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "E";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "D";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RightPathTextBox
            // 
            this.RightPathTextBox.Location = new System.Drawing.Point(3, 33);
            this.RightPathTextBox.Name = "RightPathTextBox";
            this.RightPathTextBox.Size = new System.Drawing.Size(449, 20);
            this.RightPathTextBox.TabIndex = 2;
            // 
            // RightListBox
            // 
            this.RightListBox.FormattingEnabled = true;
            this.RightListBox.Location = new System.Drawing.Point(3, 59);
            this.RightListBox.Name = "RightListBox";
            this.RightListBox.Size = new System.Drawing.Size(451, 433);
            this.RightListBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.ShowButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.CopyButton);
            this.panel1.Controls.Add(this.RenameButton);
            this.panel1.Controls.Add(this.MoveButton);
            this.panel1.Location = new System.Drawing.Point(12, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 43);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 594);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManager";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox LeftListBox;
        private System.Windows.Forms.ListBox RightListBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LeftPathTextBox;
        private System.Windows.Forms.TextBox RightPathTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}

