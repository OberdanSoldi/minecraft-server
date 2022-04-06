namespace RunMinecraftSv
{
    partial class Frm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm));
            this.button1 = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPath = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtArgs = new System.Windows.Forms.TextBox();
            this.useCustomArgs = new System.Windows.Forms.CheckBox();
            this.btnSvFolder = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(146, 12);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(116, 23);
            this.btnKill.TabIndex = 1;
            this.btnKill.Text = "Kill Server";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(12, 90);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(116, 23);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Select Server Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select Jar File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(95, 56);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(0, 15);
            this.lblServerStatus.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(95, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(72, 16);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Stopped";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtArgs
            // 
            this.txtArgs.Enabled = false;
            this.txtArgs.Location = new System.Drawing.Point(169, 187);
            this.txtArgs.Name = "txtArgs";
            this.txtArgs.Size = new System.Drawing.Size(385, 23);
            this.txtArgs.TabIndex = 11;
            this.txtArgs.Text = "-Xmx1024M -Xms1024M";
            this.txtArgs.TextChanged += new System.EventHandler(this.txtArgs_TextChanged);
            // 
            // useCustomArgs
            // 
            this.useCustomArgs.AutoSize = true;
            this.useCustomArgs.Location = new System.Drawing.Point(12, 189);
            this.useCustomArgs.Name = "useCustomArgs";
            this.useCustomArgs.Size = new System.Drawing.Size(155, 19);
            this.useCustomArgs.TabIndex = 12;
            this.useCustomArgs.Text = "Use Custom Arguments:";
            this.useCustomArgs.UseVisualStyleBackColor = true;
            this.useCustomArgs.CheckedChanged += new System.EventHandler(this.useCustomArgs_CheckedChanged);
            // 
            // btnSvFolder
            // 
            this.btnSvFolder.Enabled = false;
            this.btnSvFolder.Location = new System.Drawing.Point(12, 148);
            this.btnSvFolder.Name = "btnSvFolder";
            this.btnSvFolder.Size = new System.Drawing.Size(116, 23);
            this.btnSvFolder.TabIndex = 13;
            this.btnSvFolder.Text = "Open Server Folder";
            this.btnSvFolder.UseVisualStyleBackColor = true;
            this.btnSvFolder.Click += new System.EventHandler(this.btnSvFolder_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 216);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(542, 301);
            this.textBox4.TabIndex = 14;
            this.textBox4.WordWrap = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 527);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnSvFolder);
            this.Controls.Add(this.useCustomArgs);
            this.Controls.Add(this.txtArgs);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm";
            this.Text = "Minecraft Server Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnKill;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnPath;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label lblServerStatus;
        private TextBox textBox3;
        private TextBox txtArgs;
        private CheckBox useCustomArgs;
        private Button btnSvFolder;
        private TextBox textBox4;
        private ContextMenuStrip contextMenuStrip1;
    }
}