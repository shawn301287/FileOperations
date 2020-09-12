namespace FileOperations
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
            this.groupBox_filename_findReplace = new System.Windows.Forms.GroupBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_readDirectory = new System.Windows.Forms.Button();
            this.listBox_filenames = new System.Windows.Forms.ListBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.textBox_modified = new System.Windows.Forms.TextBox();
            this.textBox_original = new System.Windows.Forms.TextBox();
            this.textBox_folderPath = new System.Windows.Forms.TextBox();
            this.button_filename_findReplace_browse = new System.Windows.Forms.Button();
            this.folderBrowser_filename_findReplace = new System.Windows.Forms.FolderBrowserDialog();
            this.button_append = new System.Windows.Forms.Button();
            this.button_prepend = new System.Windows.Forms.Button();
            this.textBox_appendtxt = new System.Windows.Forms.TextBox();
            this.textBox_prependtxt = new System.Windows.Forms.TextBox();
            this.groupBox_filename_findReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_filename_findReplace
            // 
            this.groupBox_filename_findReplace.Controls.Add(this.textBox_prependtxt);
            this.groupBox_filename_findReplace.Controls.Add(this.textBox_appendtxt);
            this.groupBox_filename_findReplace.Controls.Add(this.button_prepend);
            this.groupBox_filename_findReplace.Controls.Add(this.button_append);
            this.groupBox_filename_findReplace.Controls.Add(this.button_clear);
            this.groupBox_filename_findReplace.Controls.Add(this.button_readDirectory);
            this.groupBox_filename_findReplace.Controls.Add(this.listBox_filenames);
            this.groupBox_filename_findReplace.Controls.Add(this.button_replace);
            this.groupBox_filename_findReplace.Controls.Add(this.textBox_modified);
            this.groupBox_filename_findReplace.Controls.Add(this.textBox_original);
            this.groupBox_filename_findReplace.Controls.Add(this.textBox_folderPath);
            this.groupBox_filename_findReplace.Controls.Add(this.button_filename_findReplace_browse);
            this.groupBox_filename_findReplace.Location = new System.Drawing.Point(12, 12);
            this.groupBox_filename_findReplace.Name = "groupBox_filename_findReplace";
            this.groupBox_filename_findReplace.Size = new System.Drawing.Size(776, 352);
            this.groupBox_filename_findReplace.TabIndex = 0;
            this.groupBox_filename_findReplace.TabStop = false;
            this.groupBox_filename_findReplace.Text = "Filename - Find & Replace";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(695, 169);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_readDirectory
            // 
            this.button_readDirectory.Location = new System.Drawing.Point(6, 48);
            this.button_readDirectory.Name = "button_readDirectory";
            this.button_readDirectory.Size = new System.Drawing.Size(143, 23);
            this.button_readDirectory.TabIndex = 6;
            this.button_readDirectory.Text = "2. Read directory";
            this.button_readDirectory.UseVisualStyleBackColor = true;
            this.button_readDirectory.Click += new System.EventHandler(this.button_readDirectory_Click);
            // 
            // listBox_filenames
            // 
            this.listBox_filenames.FormattingEnabled = true;
            this.listBox_filenames.Location = new System.Drawing.Point(6, 198);
            this.listBox_filenames.Name = "listBox_filenames";
            this.listBox_filenames.ScrollAlwaysVisible = true;
            this.listBox_filenames.Size = new System.Drawing.Size(764, 225);
            this.listBox_filenames.TabIndex = 5;
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(7, 75);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(142, 46);
            this.button_replace.TabIndex = 4;
            this.button_replace.Text = "3. Replace";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // textBox_modified
            // 
            this.textBox_modified.Location = new System.Drawing.Point(155, 101);
            this.textBox_modified.Name = "textBox_modified";
            this.textBox_modified.Size = new System.Drawing.Size(212, 20);
            this.textBox_modified.TabIndex = 3;
            this.textBox_modified.Text = "replace";
            // 
            // textBox_original
            // 
            this.textBox_original.Location = new System.Drawing.Point(155, 75);
            this.textBox_original.Name = "textBox_original";
            this.textBox_original.Size = new System.Drawing.Size(212, 20);
            this.textBox_original.TabIndex = 2;
            this.textBox_original.Text = "find";
            // 
            // textBox_folderPath
            // 
            this.textBox_folderPath.Location = new System.Drawing.Point(156, 20);
            this.textBox_folderPath.Name = "textBox_folderPath";
            this.textBox_folderPath.ReadOnly = true;
            this.textBox_folderPath.Size = new System.Drawing.Size(249, 20);
            this.textBox_folderPath.TabIndex = 1;
            // 
            // button_filename_findReplace_browse
            // 
            this.button_filename_findReplace_browse.Location = new System.Drawing.Point(6, 19);
            this.button_filename_findReplace_browse.Name = "button_filename_findReplace_browse";
            this.button_filename_findReplace_browse.Size = new System.Drawing.Size(143, 23);
            this.button_filename_findReplace_browse.TabIndex = 0;
            this.button_filename_findReplace_browse.Text = "1. Select directory";
            this.button_filename_findReplace_browse.UseVisualStyleBackColor = true;
            this.button_filename_findReplace_browse.Click += new System.EventHandler(this.button_filename_findReplace_browse_Click);
            // 
            // folderBrowser_filename_findReplace
            // 
            this.folderBrowser_filename_findReplace.HelpRequest += new System.EventHandler(this.folderBrowser_filename_findReplace_HelpRequest);
            // 
            // button_append
            // 
            this.button_append.Location = new System.Drawing.Point(7, 127);
            this.button_append.Name = "button_append";
            this.button_append.Size = new System.Drawing.Size(142, 23);
            this.button_append.TabIndex = 8;
            this.button_append.Text = "3. Append ";
            this.button_append.UseVisualStyleBackColor = true;
            this.button_append.Click += new System.EventHandler(this.button_append_Click);
            // 
            // button_prepend
            // 
            this.button_prepend.Location = new System.Drawing.Point(7, 156);
            this.button_prepend.Name = "button_prepend";
            this.button_prepend.Size = new System.Drawing.Size(142, 23);
            this.button_prepend.TabIndex = 9;
            this.button_prepend.Text = "3. Pre-pend";
            this.button_prepend.UseVisualStyleBackColor = true;
            this.button_prepend.Click += new System.EventHandler(this.button_prepend_Click);
            // 
            // textBox_appendtxt
            // 
            this.textBox_appendtxt.Location = new System.Drawing.Point(156, 127);
            this.textBox_appendtxt.Name = "textBox_appendtxt";
            this.textBox_appendtxt.Size = new System.Drawing.Size(211, 20);
            this.textBox_appendtxt.TabIndex = 10;
            // 
            // textBox_prependtxt
            // 
            this.textBox_prependtxt.Location = new System.Drawing.Point(156, 156);
            this.textBox_prependtxt.Name = "textBox_prependtxt";
            this.textBox_prependtxt.Size = new System.Drawing.Size(211, 20);
            this.textBox_prependtxt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_filename_findReplace);
            this.Name = "Form1";
            this.Text = "File Operations";
            this.groupBox_filename_findReplace.ResumeLayout(false);
            this.groupBox_filename_findReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_filename_findReplace;
        private System.Windows.Forms.Button button_filename_findReplace_browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_filename_findReplace;
        private System.Windows.Forms.TextBox textBox_folderPath;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.TextBox textBox_modified;
        private System.Windows.Forms.TextBox textBox_original;
        private System.Windows.Forms.ListBox listBox_filenames;
        private System.Windows.Forms.Button button_readDirectory;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_prepend;
        private System.Windows.Forms.Button button_append;
        private System.Windows.Forms.TextBox textBox_prependtxt;
        private System.Windows.Forms.TextBox textBox_appendtxt;
    }
}

