namespace EHentaiDownloader
{
    partial class DItem
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProgress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制下载链接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新尝试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置开始位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.移除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL：";
            // 
            // lbURL
            // 
            this.lbURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(87, 12);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(23, 12);
            this.lbURL.TabIndex = 1;
            this.lbURL.Text = "url";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title：";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(87, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(41, 12);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "wating";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progress：";
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(87, 61);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(41, 12);
            this.lbProgress.TabIndex = 5;
            this.lbProgress.Text = "wating";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status：";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(684, 61);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(41, 12);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "wating";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制下载链接ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem,
            this.重新尝试ToolStripMenuItem,
            this.设置开始位置ToolStripMenuItem,
            this.移除任务ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // 复制下载链接ToolStripMenuItem
            // 
            this.复制下载链接ToolStripMenuItem.Name = "复制下载链接ToolStripMenuItem";
            this.复制下载链接ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.复制下载链接ToolStripMenuItem.Text = "复制下载链接";
            this.复制下载链接ToolStripMenuItem.Click += new System.EventHandler(this.复制下载链接ToolStripMenuItem_Click);
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开文件夹ToolStripMenuItem.Text = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Click += new System.EventHandler(this.打开文件夹ToolStripMenuItem_Click);
            // 
            // 重新尝试ToolStripMenuItem
            // 
            this.重新尝试ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.重新尝试ToolStripMenuItem.Name = "重新尝试ToolStripMenuItem";
            this.重新尝试ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重新尝试ToolStripMenuItem.Text = "重新尝试";
            this.重新尝试ToolStripMenuItem.Click += new System.EventHandler(this.重新尝试ToolStripMenuItem_Click);
            // 
            // 设置开始位置ToolStripMenuItem
            // 
            this.设置开始位置ToolStripMenuItem.Name = "设置开始位置ToolStripMenuItem";
            this.设置开始位置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.设置开始位置ToolStripMenuItem.Text = "设置开始位置";
            this.设置开始位置ToolStripMenuItem.Click += new System.EventHandler(this.设置开始位置ToolStripMenuItem_Click);
            // 
            // lbNo
            // 
            this.lbNo.AutoSize = true;
            this.lbNo.Location = new System.Drawing.Point(5, 6);
            this.lbNo.Name = "lbNo";
            this.lbNo.Size = new System.Drawing.Size(23, 12);
            this.lbNo.TabIndex = 6;
            this.lbNo.Text = "001";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.tbCurrent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(192, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 32);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(121, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(34, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(42, 6);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(73, 21);
            this.tbCurrent.TabIndex = 0;
            this.tbCurrent.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "开始：";
            // 
            // 移除任务ToolStripMenuItem
            // 
            this.移除任务ToolStripMenuItem.Name = "移除任务ToolStripMenuItem";
            this.移除任务ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.移除任务ToolStripMenuItem.Text = "移除任务";
            this.移除任务ToolStripMenuItem.Click += new System.EventHandler(this.移除任务ToolStripMenuItem_Click);
            // 
            // DItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNo);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.label1);
            this.Name = "DItem";
            this.Size = new System.Drawing.Size(778, 87);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 复制下载链接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新尝试ToolStripMenuItem;
        private System.Windows.Forms.Label lbNo;
        private System.Windows.Forms.ToolStripMenuItem 设置开始位置ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripMenuItem 移除任务ToolStripMenuItem;
    }
}
