namespace Forms.UserControls
{
    partial class UC_MsgItem
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
            panel1 = new Panel();
            lblContent = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblContent);
            panel1.Location = new Point(30, 17);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.MaximumSize = new Size(555, 667);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15, 17, 8, 17);
            panel1.Size = new Size(47, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("宋体", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblContent.ForeColor = Color.Black;
            lblContent.ImeMode = ImeMode.NoControl;
            lblContent.Location = new Point(8, 17);
            lblContent.Margin = new Padding(0);
            lblContent.MaximumSize = new Size(420, 1667);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(15, 16);
            lblContent.TabIndex = 5;
            lblContent.Text = " ";
            lblContent.Visible = false;
            lblContent.Click += lblContent_Click;
            // 
            // UC_MsgItem
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UC_MsgItem";
            Padding = new Padding(30, 17, 15, 8);
            Size = new Size(110, 80);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lblContent;
    }
}