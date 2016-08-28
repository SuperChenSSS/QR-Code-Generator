namespace 二维码
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.选择模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.识别模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作方法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.二维码另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送到手机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选择模式ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 选择模式ToolStripMenuItem
            // 
            this.选择模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成模式ToolStripMenuItem,
            this.识别模式ToolStripMenuItem});
            this.选择模式ToolStripMenuItem.Name = "选择模式ToolStripMenuItem";
            this.选择模式ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.选择模式ToolStripMenuItem.Text = "选择模式";
            // 
            // 生成模式ToolStripMenuItem
            // 
            this.生成模式ToolStripMenuItem.Name = "生成模式ToolStripMenuItem";
            this.生成模式ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.生成模式ToolStripMenuItem.Text = "生成模式";
            this.生成模式ToolStripMenuItem.Click += new System.EventHandler(this.生成模式ToolStripMenuItem_Click);
            // 
            // 识别模式ToolStripMenuItem
            // 
            this.识别模式ToolStripMenuItem.Name = "识别模式ToolStripMenuItem";
            this.识别模式ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.识别模式ToolStripMenuItem.Text = "识别模式";
            this.识别模式ToolStripMenuItem.Click += new System.EventHandler(this.识别模式ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作方法ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 操作方法ToolStripMenuItem
            // 
            this.操作方法ToolStripMenuItem.Name = "操作方法ToolStripMenuItem";
            this.操作方法ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.操作方法ToolStripMenuItem.Text = "操作方法";
            this.操作方法ToolStripMenuItem.Click += new System.EventHandler(this.操作方法ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox1.Location = new System.Drawing.Point(58, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 34);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "请选择模式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(82, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 227);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.二维码另存为ToolStripMenuItem,
            this.发送到手机ToolStripMenuItem,
            this.属性ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 82);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 二维码另存为ToolStripMenuItem
            // 
            this.二维码另存为ToolStripMenuItem.Name = "二维码另存为ToolStripMenuItem";
            this.二维码另存为ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.二维码另存为ToolStripMenuItem.Text = "二维码另存为";
            this.二维码另存为ToolStripMenuItem.Click += new System.EventHandler(this.二维码另存为ToolStripMenuItem_Click);
            // 
            // 发送到手机ToolStripMenuItem
            // 
            this.发送到手机ToolStripMenuItem.Name = "发送到手机ToolStripMenuItem";
            this.发送到手机ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.发送到手机ToolStripMenuItem.Text = "发送到手机";
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.属性ToolStripMenuItem.Text = "属性";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(449, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二维码生成/识别--陈梦杨实习";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 选择模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 识别模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作方法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 二维码另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送到手机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
    }
}

