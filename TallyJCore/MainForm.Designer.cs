﻿namespace TallyJCore
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.txtFolder = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.NumericUpDown();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.txtURL = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnView = new System.Windows.Forms.Button();
      this.lblStatus = new System.Windows.Forms.Label();
      this.btnCopyToClipboard = new System.Windows.Forms.Button();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyURLToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.startServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.stopServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewInBrowserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.copyURLToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.qrCodeImgControl1 = new Gma.QrCodeNet.Encoding.Windows.Controls.QrCodeImgControl();
      this.lblQrCode = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtConnectionString = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.txtPort)).BeginInit();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.qrCodeImgControl1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtFolder
      // 
      this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFolder.Location = new System.Drawing.Point(155, 63);
      this.txtFolder.Name = "txtFolder";
      this.txtFolder.Size = new System.Drawing.Size(369, 20);
      this.txtFolder.TabIndex = 3;
      this.txtFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(132, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Folder containing &web files";
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectFolder.Location = new System.Drawing.Point(530, 60);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(98, 25);
      this.btnSelectFolder.TabIndex = 4;
      this.btnSelectFolder.Text = "Select Folder";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(23, 117);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(96, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Web Server &Port #";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(155, 115);
      this.txtPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.txtPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(70, 20);
      this.txtPort.TabIndex = 8;
      this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtPort.Value = new decimal(new int[] {
            9595,
            0,
            0,
            0});
      this.txtPort.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(26, 143);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(105, 33);
      this.btnStart.TabIndex = 9;
      this.btnStart.Text = "&Start Server";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.Enabled = false;
      this.btnStop.Location = new System.Drawing.Point(137, 143);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(105, 33);
      this.btnStop.TabIndex = 10;
      this.btnStop.Text = "St&op Server";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // txtURL
      // 
      this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtURL.Location = new System.Drawing.Point(155, 280);
      this.txtURL.Name = "txtURL";
      this.txtURL.ReadOnly = true;
      this.txtURL.Size = new System.Drawing.Size(369, 20);
      this.txtURL.TabIndex = 15;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(23, 283);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(109, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "URL for clients to use";
      // 
      // btnView
      // 
      this.btnView.Location = new System.Drawing.Point(155, 306);
      this.btnView.Name = "btnView";
      this.btnView.Size = new System.Drawing.Size(109, 30);
      this.btnView.TabIndex = 16;
      this.btnView.Text = "View in &Browser";
      this.btnView.UseVisualStyleBackColor = true;
      this.btnView.Click += new System.EventHandler(this.btnView_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStatus.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblStatus.Location = new System.Drawing.Point(251, 148);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(109, 24);
      this.lblStatus.TabIndex = 12;
      this.lblStatus.Text = "Not running";
      // 
      // btnCopyToClipboard
      // 
      this.btnCopyToClipboard.Location = new System.Drawing.Point(155, 342);
      this.btnCopyToClipboard.Name = "btnCopyToClipboard";
      this.btnCopyToClipboard.Size = new System.Drawing.Size(109, 30);
      this.btnCopyToClipboard.TabIndex = 17;
      this.btnCopyToClipboard.Text = "Copy to &Clipboard";
      this.btnCopyToClipboard.UseVisualStyleBackColor = true;
      this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // startServerToolStripMenuItem
      // 
      this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
      this.startServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.startServerToolStripMenuItem.Text = "&Start Server";
      this.startServerToolStripMenuItem.Click += new System.EventHandler(this.startServerToolStripMenuItem_Click);
      // 
      // stopServerToolStripMenuItem
      // 
      this.stopServerToolStripMenuItem.Enabled = false;
      this.stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
      this.stopServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.stopServerToolStripMenuItem.Text = "Stop Server";
      this.stopServerToolStripMenuItem.Click += new System.EventHandler(this.stopServerToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // clientsToolStripMenuItem
      // 
      this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
      this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.clientsToolStripMenuItem.Text = "&Clients";
      // 
      // copyURLToClipboardToolStripMenuItem
      // 
      this.copyURLToClipboardToolStripMenuItem.Name = "copyURLToClipboardToolStripMenuItem";
      this.copyURLToClipboardToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.copyURLToClipboardToolStripMenuItem.Text = "&Copy URL to clipboard";
      this.copyURLToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyURLToClipboardToolStripMenuItem_Click);
      // 
      // viewInBrowserToolStripMenuItem
      // 
      this.viewInBrowserToolStripMenuItem.Name = "viewInBrowserToolStripMenuItem";
      this.viewInBrowserToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
      this.viewInBrowserToolStripMenuItem.Text = "&View in Browser";
      this.viewInBrowserToolStripMenuItem.Click += new System.EventHandler(this.viewInBrowserToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.aboutToolStripMenuItem.Text = "&About TallyJ";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.clientToolStripMenuItem,
            this.aboutToolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(653, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem1
      // 
      this.fileToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerToolStripMenuItem1,
            this.stopServerToolStripMenuItem1,
            this.exitToolStripMenuItem1});
      this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
      this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem1.Text = "&File";
      // 
      // startServerToolStripMenuItem1
      // 
      this.startServerToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.startServerToolStripMenuItem1.Name = "startServerToolStripMenuItem1";
      this.startServerToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
      this.startServerToolStripMenuItem1.Text = "&Start Server";
      this.startServerToolStripMenuItem1.Click += new System.EventHandler(this.startServerToolStripMenuItem1_Click);
      // 
      // stopServerToolStripMenuItem1
      // 
      this.stopServerToolStripMenuItem1.Name = "stopServerToolStripMenuItem1";
      this.stopServerToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
      this.stopServerToolStripMenuItem1.Text = "St&op Server";
      this.stopServerToolStripMenuItem1.Click += new System.EventHandler(this.stopServerToolStripMenuItem1_Click);
      // 
      // exitToolStripMenuItem1
      // 
      this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
      this.exitToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
      this.exitToolStripMenuItem1.Text = "E&xit";
      this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
      // 
      // clientToolStripMenuItem
      // 
      this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInBrowserToolStripMenuItem1,
            this.copyURLToClipboardToolStripMenuItem1});
      this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
      this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.clientToolStripMenuItem.Text = "&Client";
      // 
      // viewInBrowserToolStripMenuItem1
      // 
      this.viewInBrowserToolStripMenuItem1.Name = "viewInBrowserToolStripMenuItem1";
      this.viewInBrowserToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
      this.viewInBrowserToolStripMenuItem1.Text = "View in &Browser";
      this.viewInBrowserToolStripMenuItem1.Click += new System.EventHandler(this.viewInBrowserToolStripMenuItem1_Click);
      // 
      // copyURLToClipboardToolStripMenuItem1
      // 
      this.copyURLToClipboardToolStripMenuItem1.Name = "copyURLToClipboardToolStripMenuItem1";
      this.copyURLToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
      this.copyURLToClipboardToolStripMenuItem1.Text = "Copy URL to &Clipboard";
      this.copyURLToClipboardToolStripMenuItem1.Click += new System.EventHandler(this.copyURLToClipboardToolStripMenuItem1_Click);
      // 
      // aboutToolStripMenuItem1
      // 
      this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem2});
      this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
      this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
      this.aboutToolStripMenuItem1.Text = "&Help";
      // 
      // aboutToolStripMenuItem2
      // 
      this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
      this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem2.Text = "&About";
      // 
      // qrCodeImgControl1
      // 
      this.qrCodeImgControl1.Image = ((System.Drawing.Image)(resources.GetObject("qrCodeImgControl1.Image")));
      this.qrCodeImgControl1.LightBrush = System.Drawing.SystemColors.Control;
      this.qrCodeImgControl1.Location = new System.Drawing.Point(270, 304);
      this.qrCodeImgControl1.Name = "qrCodeImgControl1";
      this.qrCodeImgControl1.Size = new System.Drawing.Size(90, 90);
      this.qrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.qrCodeImgControl1.TabIndex = 14;
      this.qrCodeImgControl1.TabStop = false;
      // 
      // lblQrCode
      // 
      this.lblQrCode.AutoSize = true;
      this.lblQrCode.ForeColor = System.Drawing.SystemColors.GrayText;
      this.lblQrCode.Location = new System.Drawing.Point(366, 310);
      this.lblQrCode.Name = "lblQrCode";
      this.lblQrCode.Size = new System.Drawing.Size(126, 26);
      this.lblQrCode.TabIndex = 0;
      this.lblQrCode.Text = "QR Code showing URL\r\nfor use by mobile devices";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 36);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(181, 24);
      this.label4.TabIndex = 1;
      this.label4.Text = "Server Configuration";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(23, 92);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(110, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "&Database Connection";
      // 
      // txtConnectionString
      // 
      this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtConnectionString.Location = new System.Drawing.Point(155, 89);
      this.txtConnectionString.Name = "txtConnectionString";
      this.txtConnectionString.Size = new System.Drawing.Size(369, 20);
      this.txtConnectionString.TabIndex = 6;
      this.txtConnectionString.TextChanged += new System.EventHandler(this.txtConnectionString_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(12, 253);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(154, 24);
      this.label6.TabIndex = 13;
      this.label6.Text = "Client Information";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(530, 87);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(98, 25);
      this.button1.TabIndex = 18;
      this.button1.Text = "Load from File";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(653, 573);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtConnectionString);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.lblQrCode);
      this.Controls.Add(this.qrCodeImgControl1);
      this.Controls.Add(this.btnCopyToClipboard);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnView);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtURL);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.txtPort);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtFolder);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MinimumSize = new System.Drawing.Size(320, 342);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "TallyJ Standalone Server";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.Resize += new System.EventHandler(this.MainForm_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.txtPort)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.qrCodeImgControl1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown txtPort;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.TextBox txtURL;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnView;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Button btnCopyToClipboard;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem startServerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stopServerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyURLToClipboardToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewInBrowserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem startServerToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem stopServerToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viewInBrowserToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem copyURLToClipboardToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
    private Gma.QrCodeNet.Encoding.Windows.Controls.QrCodeImgControl qrCodeImgControl1;
    private System.Windows.Forms.Label lblQrCode;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtConnectionString;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button1;
  }
}

