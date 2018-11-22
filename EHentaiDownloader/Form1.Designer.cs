namespace EHentaiDownloader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入任务记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入任务记录ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.导入全部任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开下载目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除已完成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重启Error任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.导出未完成任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbURL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(487, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加任务";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbURL
            // 
            this.tbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbURL.Location = new System.Drawing.Point(66, 20);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(415, 21);
            this.tbURL.TabIndex = 1;
            this.tbURL.Text = "https://e-hentai.org/g/812621/fbc78efeca/";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(14, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 284);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "任务列表";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 264);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(599, 25);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入任务记录ToolStripMenuItem,
            this.导出未完成任务ToolStripMenuItem,
            this.导入任务记录ToolStripMenuItem1,
            this.导入全部任务ToolStripMenuItem,
            this.打开下载目录ToolStripMenuItem});
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.说明ToolStripMenuItem.Text = "文件";
            // 
            // 导入任务记录ToolStripMenuItem
            // 
            this.导入任务记录ToolStripMenuItem.Name = "导入任务记录ToolStripMenuItem";
            this.导入任务记录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入任务记录ToolStripMenuItem.Text = "导出全部任务";
            this.导入任务记录ToolStripMenuItem.Click += new System.EventHandler(this.导入任务记录ToolStripMenuItem_Click);
            // 
            // 导入任务记录ToolStripMenuItem1
            // 
            this.导入任务记录ToolStripMenuItem1.Name = "导入任务记录ToolStripMenuItem1";
            this.导入任务记录ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.导入任务记录ToolStripMenuItem1.Text = "导入错误任务";
            this.导入任务记录ToolStripMenuItem1.Click += new System.EventHandler(this.导入任务记录ToolStripMenuItem1_Click);
            // 
            // 导入全部任务ToolStripMenuItem
            // 
            this.导入全部任务ToolStripMenuItem.Name = "导入全部任务ToolStripMenuItem";
            this.导入全部任务ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导入全部任务ToolStripMenuItem.Text = "导入全部任务";
            this.导入全部任务ToolStripMenuItem.Click += new System.EventHandler(this.导入全部任务ToolStripMenuItem_Click);
            // 
            // 打开下载目录ToolStripMenuItem
            // 
            this.打开下载目录ToolStripMenuItem.Name = "打开下载目录ToolStripMenuItem";
            this.打开下载目录ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开下载目录ToolStripMenuItem.Text = "打开下载目录";
            this.打开下载目录ToolStripMenuItem.Click += new System.EventHandler(this.打开下载目录ToolStripMenuItem_Click);
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移除已完成ToolStripMenuItem,
            this.移除ErrorToolStripMenuItem,
            this.重启Error任务ToolStripMenuItem});
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 移除已完成ToolStripMenuItem
            // 
            this.移除已完成ToolStripMenuItem.Name = "移除已完成ToolStripMenuItem";
            this.移除已完成ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.移除已完成ToolStripMenuItem.Text = "移除已完成";
            this.移除已完成ToolStripMenuItem.Click += new System.EventHandler(this.移除已完成ToolStripMenuItem_Click);
            // 
            // 移除ErrorToolStripMenuItem
            // 
            this.移除ErrorToolStripMenuItem.Name = "移除ErrorToolStripMenuItem";
            this.移除ErrorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.移除ErrorToolStripMenuItem.Text = "移除Error";
            this.移除ErrorToolStripMenuItem.Click += new System.EventHandler(this.移除ErrorToolStripMenuItem_Click);
            // 
            // 重启Error任务ToolStripMenuItem
            // 
            this.重启Error任务ToolStripMenuItem.Name = "重启Error任务ToolStripMenuItem";
            this.重启Error任务ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.重启Error任务ToolStripMenuItem.Text = "重启Error任务";
            this.重启Error任务ToolStripMenuItem.Click += new System.EventHandler(this.重启Error任务ToolStripMenuItem_Click);
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem1});
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.版本ToolStripMenuItem.Text = "版本";
            // 
            // 说明ToolStripMenuItem1
            // 
            this.说明ToolStripMenuItem1.Name = "说明ToolStripMenuItem1";
            this.说明ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.说明ToolStripMenuItem1.Text = "说明";
            this.说明ToolStripMenuItem1.Click += new System.EventHandler(this.说明ToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "EHentai";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // 导出未完成任务ToolStripMenuItem
            // 
            this.导出未完成任务ToolStripMenuItem.Name = "导出未完成任务ToolStripMenuItem";
            this.导出未完成任务ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.导出未完成任务ToolStripMenuItem.Text = "导出未完成任务";
            this.导出未完成任务ToolStripMenuItem.Click += new System.EventHandler(this.导出未完成任务ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "E-Hentai Image Downloader";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入任务记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 导入任务记录ToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 导入全部任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开下载目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除已完成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重启Error任务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出未完成任务ToolStripMenuItem;
    }
}

