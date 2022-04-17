namespace Server
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remoteShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executenetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keylogerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUILDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ping = new System.Windows.Forms.Timer(this.components);
            this.UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.ThumbnailImageList = new System.Windows.Forms.ImageList(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lv_Hiwd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Lan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Wan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Computer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Os = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Ping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuClient.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuClient
            // 
            this.contextMenuClient.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteShellToolStripMenuItem,
            this.fileManagerToolStripMenuItem,
            this.executenetToolStripMenuItem,
            this.remoteDesktopToolStripMenuItem,
            this.keylogerToolStripMenuItem,
            this.bUILDERToolStripMenuItem});
            this.contextMenuClient.Name = "contextMenuStrip1";
            this.contextMenuClient.Size = new System.Drawing.Size(171, 136);
            // 
            // remoteShellToolStripMenuItem
            // 
            this.remoteShellToolStripMenuItem.Name = "remoteShellToolStripMenuItem";
            this.remoteShellToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.remoteShellToolStripMenuItem.Text = "remote shell";
            this.remoteShellToolStripMenuItem.Click += new System.EventHandler(this.RemoteShellToolStripMenuItem1_Click_1);
            // 
            // fileManagerToolStripMenuItem
            // 
            this.fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            this.fileManagerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.fileManagerToolStripMenuItem.Text = "file Manager";
            this.fileManagerToolStripMenuItem.Click += new System.EventHandler(this.FileManagerToolStripMenuItem1_Click);
            // 
            // executenetToolStripMenuItem
            // 
            this.executenetToolStripMenuItem.Name = "executenetToolStripMenuItem";
            this.executenetToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.executenetToolStripMenuItem.Text = "execute .net";
            this.executenetToolStripMenuItem.Click += new System.EventHandler(this.ExecuteNETCodeToolStripMenuItem_Click_1);
            // 
            // remoteDesktopToolStripMenuItem
            // 
            this.remoteDesktopToolStripMenuItem.Name = "remoteDesktopToolStripMenuItem";
            this.remoteDesktopToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.remoteDesktopToolStripMenuItem.Text = "remote desktop";
            this.remoteDesktopToolStripMenuItem.Click += new System.EventHandler(this.RemoteDesktopToolStripMenuItem1_Click);
            // 
            // keylogerToolStripMenuItem
            // 
            this.keylogerToolStripMenuItem.Name = "keylogerToolStripMenuItem";
            this.keylogerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.keylogerToolStripMenuItem.Text = "keyloger";
            this.keylogerToolStripMenuItem.Click += new System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
            // 
            // bUILDERToolStripMenuItem
            // 
            this.bUILDERToolStripMenuItem.Name = "bUILDERToolStripMenuItem";
            this.bUILDERToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.bUILDERToolStripMenuItem.Text = "Build";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel2.Text = "[Notification]             ";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.ToolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(17, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // ping
            // 
            this.ping.Enabled = true;
            this.ping.Interval = 30000;
            this.ping.Tick += new System.EventHandler(this.ping_Tick);
            // 
            // UpdateUI
            // 
            this.UpdateUI.Enabled = true;
            this.UpdateUI.Interval = 500;
            this.UpdateUI.Tick += new System.EventHandler(this.UpdateUI_Tick);
            // 
            // ThumbnailImageList
            // 
            this.ThumbnailImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ThumbnailImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ThumbnailImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Memory";
            this.performanceCounter2.CounterName = "% Committed Bytes In Use";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AsyncRAT";
            this.notifyIcon1.Visible = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(765, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(2, 2);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.ShowGroups = false;
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(761, 343);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 1078;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(765, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_Hiwd,
            this.lv_Lan,
            this.lv_Wan,
            this.lv_Computer,
            this.lv_User,
            this.lv_Os,
            this.lv_Ping});
            this.listView1.ContextMenuStrip = this.contextMenuClient;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(761, 343);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            // 
            // lv_Hiwd
            // 
            this.lv_Hiwd.Text = "HIWD";
            this.lv_Hiwd.Width = 120;
            // 
            // lv_Lan
            // 
            this.lv_Lan.Text = "LAN";
            this.lv_Lan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Lan.Width = 110;
            // 
            // lv_Wan
            // 
            this.lv_Wan.Text = "WAN";
            this.lv_Wan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Wan.Width = 110;
            // 
            // lv_Computer
            // 
            this.lv_Computer.Text = "COMPUTER";
            this.lv_Computer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Computer.Width = 120;
            // 
            // lv_User
            // 
            this.lv_User.Text = "USERNAME";
            this.lv_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_User.Width = 100;
            // 
            // lv_Os
            // 
            this.lv_Os.Text = "SYSTEM";
            this.lv_Os.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Os.Width = 150;
            // 
            // lv_Ping
            // 
            this.lv_Ping.Text = "PING";
            this.lv_Ping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lv_Ping.Width = 50;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 373);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 395);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncRAT2.0";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuClient.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuClient;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer ping;
        private System.Windows.Forms.Timer UpdateUI;
        private System.Windows.Forms.ToolStripMenuItem bUILDERToolStripMenuItem;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        public System.Windows.Forms.ImageList ThumbnailImageList;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lv_Hiwd;
        private System.Windows.Forms.ColumnHeader lv_Lan;
        private System.Windows.Forms.ColumnHeader lv_Wan;
        public System.Windows.Forms.ColumnHeader lv_Computer;
        private System.Windows.Forms.ColumnHeader lv_User;
        private System.Windows.Forms.ColumnHeader lv_Os;
        public System.Windows.Forms.ColumnHeader lv_Ping;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keylogerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteShellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executenetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem;
    }
}

