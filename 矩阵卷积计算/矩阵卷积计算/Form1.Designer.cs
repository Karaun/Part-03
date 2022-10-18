
namespace 矩阵卷积计算
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMatrix1 = new System.Windows.Forms.TextBox();
            this.txtMatrix2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMatrix3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开被卷积矩阵ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开核矩阵ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.导出结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMatrix1
            // 
            this.txtMatrix1.Location = new System.Drawing.Point(22, 57);
            this.txtMatrix1.Multiline = true;
            this.txtMatrix1.Name = "txtMatrix1";
            this.txtMatrix1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix1.Size = new System.Drawing.Size(288, 198);
            this.txtMatrix1.TabIndex = 0;
            this.txtMatrix1.Text = resources.GetString("txtMatrix1.Text");
            this.txtMatrix1.WordWrap = false;
            // 
            // txtMatrix2
            // 
            this.txtMatrix2.Location = new System.Drawing.Point(22, 277);
            this.txtMatrix2.Multiline = true;
            this.txtMatrix2.Name = "txtMatrix2";
            this.txtMatrix2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix2.Size = new System.Drawing.Size(288, 193);
            this.txtMatrix2.TabIndex = 1;
            this.txtMatrix2.Text = "0.20 0.30 0.20\r\n0.25 0.50 0.35\r\n0.10 0.30 0.20";
            this.txtMatrix2.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "被卷积矩阵";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(20, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "核矩阵";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(333, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "算法1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(333, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "算法2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMatrix3
            // 
            this.txtMatrix3.Location = new System.Drawing.Point(463, 57);
            this.txtMatrix3.Multiline = true;
            this.txtMatrix3.Name = "txtMatrix3";
            this.txtMatrix3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix3.Size = new System.Drawing.Size(311, 217);
            this.txtMatrix3.TabIndex = 7;
            this.txtMatrix3.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.导出结果ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开被卷积矩阵ToolStripMenuItem,
            this.打开核矩阵ToolStripMenuItem});
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 打开被卷积矩阵ToolStripMenuItem
            // 
            this.打开被卷积矩阵ToolStripMenuItem.Name = "打开被卷积矩阵ToolStripMenuItem";
            this.打开被卷积矩阵ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开被卷积矩阵ToolStripMenuItem.Text = "打开被卷积矩阵";
            this.打开被卷积矩阵ToolStripMenuItem.Click += new System.EventHandler(this.打开被卷积矩阵ToolStripMenuItem_Click);
            // 
            // 打开核矩阵ToolStripMenuItem
            // 
            this.打开核矩阵ToolStripMenuItem.Name = "打开核矩阵ToolStripMenuItem";
            this.打开核矩阵ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开核矩阵ToolStripMenuItem.Text = "打开核矩阵";
            this.打开核矩阵ToolStripMenuItem.Click += new System.EventHandler(this.打开核矩阵ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(460, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "计算结果";
            // 
            // 导出结果ToolStripMenuItem
            // 
            this.导出结果ToolStripMenuItem.Name = "导出结果ToolStripMenuItem";
            this.导出结果ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导出结果ToolStripMenuItem.Text = "导出结果";
            this.导出结果ToolStripMenuItem.Click += new System.EventHandler(this.导出结果ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatrix3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatrix2);
            this.Controls.Add(this.txtMatrix1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "矩阵卷积计算器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatrix1;
        private System.Windows.Forms.TextBox txtMatrix2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMatrix3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 打开被卷积矩阵ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开核矩阵ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出结果ToolStripMenuItem;
    }
}

