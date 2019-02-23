namespace Snake
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_START = new System.Windows.Forms.Button();
            this.Button_EXIT = new System.Windows.Forms.Button();
            this.Button_INIT = new System.Windows.Forms.Button();
            this.ComboBox_difficult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(114, 28);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(500, 500);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(500, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(500, 500);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Button_START
            // 
            this.Button_START.Location = new System.Drawing.Point(875, 96);
            this.Button_START.Name = "Button_START";
            this.Button_START.Size = new System.Drawing.Size(129, 106);
            this.Button_START.TabIndex = 1;
            this.Button_START.Text = "开始";
            this.Button_START.UseVisualStyleBackColor = true;
            this.Button_START.Click += new System.EventHandler(this.Button_START_Click);
            // 
            // Button_EXIT
            // 
            this.Button_EXIT.Location = new System.Drawing.Point(875, 314);
            this.Button_EXIT.Name = "Button_EXIT";
            this.Button_EXIT.Size = new System.Drawing.Size(129, 106);
            this.Button_EXIT.TabIndex = 1;
            this.Button_EXIT.TabStop = false;
            this.Button_EXIT.Text = "退出";
            this.Button_EXIT.UseVisualStyleBackColor = true;
            this.Button_EXIT.Click += new System.EventHandler(this.Button_EXIT_Click);
            // 
            // Button_INIT
            // 
            this.Button_INIT.Location = new System.Drawing.Point(875, 505);
            this.Button_INIT.Name = "Button_INIT";
            this.Button_INIT.Size = new System.Drawing.Size(129, 106);
            this.Button_INIT.TabIndex = 1;
            this.Button_INIT.TabStop = false;
            this.Button_INIT.Text = "初始化";
            this.Button_INIT.UseVisualStyleBackColor = true;
            this.Button_INIT.Click += new System.EventHandler(this.Button_INIT_Click);
            // 
            // ComboBox_difficult
            // 
            this.ComboBox_difficult.Font = new System.Drawing.Font("宋体", 15.75F);
            this.ComboBox_difficult.FormattingEnabled = true;
            this.ComboBox_difficult.Items.AddRange(new object[] {
            "新手",
            "老手",
            "宗师"});
            this.ComboBox_difficult.Location = new System.Drawing.Point(236, 591);
            this.ComboBox_difficult.Name = "ComboBox_difficult";
            this.ComboBox_difficult.Size = new System.Drawing.Size(70, 29);
            this.ComboBox_difficult.TabIndex = 2;
            this.ComboBox_difficult.Text = "难度";
            this.ComboBox_difficult.SelectedIndexChanged += new System.EventHandler(this.ComboBox_difficult_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 801);
            this.Controls.Add(this.ComboBox_difficult);
            this.Controls.Add(this.Button_INIT);
            this.Controls.Add(this.Button_EXIT);
            this.Controls.Add(this.Button_START);
            this.Controls.Add(this.flowLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Button_START;
        private System.Windows.Forms.Button Button_EXIT;
        private System.Windows.Forms.Button Button_INIT;
        public System.Windows.Forms.ComboBox ComboBox_difficult;
    }
}

