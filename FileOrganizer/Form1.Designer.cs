namespace FileOrganizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            this.modifiedDateRadioButton = new System.Windows.Forms.RadioButton();
            this.createdDateRadioButton = new System.Windows.Forms.RadioButton();
            this.leaveFiles6MradioButton = new System.Windows.Forms.RadioButton();
            this.leaveFiles3MRadioButton = new System.Windows.Forms.RadioButton();
            this.leave1MFilesradioButton1 = new System.Windows.Forms.RadioButton();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.subfolderPatternTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.RunButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.patternpreviewLabel = new System.Windows.Forms.Label();
            this.leaveNoFilesRadioButton = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 17);
            label1.TabIndex = 1;
            label1.Text = "Path";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(157, 17);
            label2.TabIndex = 3;
            label2.Text = "Subfolder name pattern";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.modifiedDateRadioButton);
            groupBox1.Controls.Add(this.createdDateRadioButton);
            groupBox1.Location = new System.Drawing.Point(16, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(127, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sort by";
            // 
            // modifiedDateRadioButton
            // 
            this.modifiedDateRadioButton.AutoSize = true;
            this.modifiedDateRadioButton.Checked = true;
            this.modifiedDateRadioButton.Location = new System.Drawing.Point(7, 50);
            this.modifiedDateRadioButton.Name = "modifiedDateRadioButton";
            this.modifiedDateRadioButton.Size = new System.Drawing.Size(114, 21);
            this.modifiedDateRadioButton.TabIndex = 1;
            this.modifiedDateRadioButton.TabStop = true;
            this.modifiedDateRadioButton.Tag = "Modified";
            this.modifiedDateRadioButton.Text = "Modified date";
            this.modifiedDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // createdDateRadioButton
            // 
            this.createdDateRadioButton.AutoSize = true;
            this.createdDateRadioButton.Location = new System.Drawing.Point(7, 22);
            this.createdDateRadioButton.Name = "createdDateRadioButton";
            this.createdDateRadioButton.Size = new System.Drawing.Size(111, 21);
            this.createdDateRadioButton.TabIndex = 0;
            this.createdDateRadioButton.Tag = "Created";
            this.createdDateRadioButton.Text = "Created date";
            this.createdDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.leaveNoFilesRadioButton);
            groupBox2.Controls.Add(this.leaveFiles6MradioButton);
            groupBox2.Controls.Add(this.leaveFiles3MRadioButton);
            groupBox2.Controls.Add(this.leave1MFilesradioButton1);
            groupBox2.Location = new System.Drawing.Point(150, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(196, 100);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Leave files newer then...";
            // 
            // leaveFiles6MradioButton
            // 
            this.leaveFiles6MradioButton.AutoSize = true;
            this.leaveFiles6MradioButton.Location = new System.Drawing.Point(6, 77);
            this.leaveFiles6MradioButton.Name = "leaveFiles6MradioButton";
            this.leaveFiles6MradioButton.Size = new System.Drawing.Size(87, 21);
            this.leaveFiles6MradioButton.TabIndex = 2;
            this.leaveFiles6MradioButton.Tag = "6";
            this.leaveFiles6MradioButton.Text = "6 months";
            this.leaveFiles6MradioButton.UseVisualStyleBackColor = true;
            // 
            // leaveFiles3MRadioButton
            // 
            this.leaveFiles3MRadioButton.AutoSize = true;
            this.leaveFiles3MRadioButton.Checked = true;
            this.leaveFiles3MRadioButton.Location = new System.Drawing.Point(6, 50);
            this.leaveFiles3MRadioButton.Name = "leaveFiles3MRadioButton";
            this.leaveFiles3MRadioButton.Size = new System.Drawing.Size(87, 21);
            this.leaveFiles3MRadioButton.TabIndex = 1;
            this.leaveFiles3MRadioButton.TabStop = true;
            this.leaveFiles3MRadioButton.Tag = "3";
            this.leaveFiles3MRadioButton.Text = "3 months";
            this.leaveFiles3MRadioButton.UseVisualStyleBackColor = true;
            // 
            // leave1MFilesradioButton1
            // 
            this.leave1MFilesradioButton1.AutoSize = true;
            this.leave1MFilesradioButton1.Location = new System.Drawing.Point(6, 23);
            this.leave1MFilesradioButton1.Name = "leave1MFilesradioButton1";
            this.leave1MFilesradioButton1.Size = new System.Drawing.Size(80, 21);
            this.leave1MFilesradioButton1.TabIndex = 0;
            this.leave1MFilesradioButton1.Tag = "1";
            this.leave1MFilesradioButton1.Text = "1 month";
            this.leave1MFilesradioButton1.UseVisualStyleBackColor = true;
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(65, 10);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(435, 22);
            this.folderPathTextBox.TabIndex = 0;
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(506, 10);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(75, 23);
            this.folderBrowserButton.TabIndex = 2;
            this.folderBrowserButton.Text = "Browse";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // subfolderPatternTextBox
            // 
            this.subfolderPatternTextBox.Location = new System.Drawing.Point(185, 44);
            this.subfolderPatternTextBox.Name = "subfolderPatternTextBox";
            this.subfolderPatternTextBox.Size = new System.Drawing.Size(161, 22);
            this.subfolderPatternTextBox.TabIndex = 4;
            this.subfolderPatternTextBox.Text = "yyyy\\\\MM";
            this.subfolderPatternTextBox.TextChanged += new System.EventHandler(this.subfolderPatternTextBox_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(565, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(506, 121);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 51);
            this.RunButton.TabIndex = 7;
            this.RunButton.Text = "GO!";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(425, 122);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 51);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // patternpreviewLabel
            // 
            this.patternpreviewLabel.AutoSize = true;
            this.patternpreviewLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patternpreviewLabel.Location = new System.Drawing.Point(352, 47);
            this.patternpreviewLabel.Name = "patternpreviewLabel";
            this.patternpreviewLabel.Size = new System.Drawing.Size(46, 17);
            this.patternpreviewLabel.TabIndex = 9;
            this.patternpreviewLabel.Text = "label3";
            // 
            // leaveNoFilesRadioButton
            // 
            this.leaveNoFilesRadioButton.AutoSize = true;
            this.leaveNoFilesRadioButton.Location = new System.Drawing.Point(112, 23);
            this.leaveNoFilesRadioButton.Name = "leaveNoFilesRadioButton";
            this.leaveNoFilesRadioButton.Size = new System.Drawing.Size(69, 21);
            this.leaveNoFilesRadioButton.TabIndex = 3;
            this.leaveNoFilesRadioButton.TabStop = true;
            this.leaveNoFilesRadioButton.Text = "Ignore";
            this.leaveNoFilesRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 216);
            this.Controls.Add(groupBox2);
            this.Controls.Add(this.patternpreviewLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.subfolderPatternTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(label1);
            this.Controls.Add(this.folderPathTextBox);
            this.Name = "Form1";
            this.Text = "FileOrganizer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.TextBox subfolderPatternTextBox;
        private System.Windows.Forms.RadioButton modifiedDateRadioButton;
        private System.Windows.Forms.RadioButton createdDateRadioButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label patternpreviewLabel;
        private System.Windows.Forms.RadioButton leaveFiles6MradioButton;
        private System.Windows.Forms.RadioButton leaveFiles3MRadioButton;
        private System.Windows.Forms.RadioButton leave1MFilesradioButton1;
        private System.Windows.Forms.RadioButton leaveNoFilesRadioButton;
    }
}

