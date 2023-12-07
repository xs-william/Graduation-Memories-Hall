namespace Forms
{
    partial class CommandChat
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
            senderProfile = new Sunny.UI.UIImageButton();
            name = new Sunny.UI.UITextBox();
            sendContent = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)senderProfile).BeginInit();
            SuspendLayout();
            // 
            // senderProfile
            // 
            senderProfile.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            senderProfile.Location = new Point(3, 3);
            senderProfile.Name = "senderProfile";
            senderProfile.Size = new Size(49, 49);
            senderProfile.TabIndex = 0;
            senderProfile.TabStop = false;
            senderProfile.Text = "uiImageButton1";
            senderProfile.Click += senderProfile_Click;
            // 
            // name
            // 
            name.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name.IconSize = 10;
            name.Location = new Point(59, 3);
            name.Margin = new Padding(4, 5, 4, 5);
            name.MinimumSize = new Size(1, 16);
            name.Name = "name";
            name.Padding = new Padding(5);
            name.RectSides = ToolStripStatusLabelBorderSides.None;
            name.ShowText = false;
            name.Size = new Size(58, 22);
            name.SymbolSize = 10;
            name.TabIndex = 1;
            name.Text = "name";
            name.TextAlignment = ContentAlignment.MiddleLeft;
            name.Watermark = "";
            // 
            // sendContent
            // 
            sendContent.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            sendContent.Location = new Point(59, 25);
            sendContent.Margin = new Padding(4, 5, 4, 5);
            sendContent.MinimumSize = new Size(1, 16);
            sendContent.Name = "sendContent";
            sendContent.Padding = new Padding(5);
            sendContent.RectSides = ToolStripStatusLabelBorderSides.None;
            sendContent.ShowText = false;
            sendContent.Size = new Size(194, 37);
            sendContent.TabIndex = 2;
            sendContent.Text = "uiTextBox1";
            sendContent.TextAlignment = ContentAlignment.MiddleLeft;
            sendContent.Watermark = "";
            // 
            // CommandChat
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sendContent);
            Controls.Add(name);
            Controls.Add(senderProfile);
            Name = "CommandChat";
            Size = new Size(442, 67);
            ((System.ComponentModel.ISupportInitialize)senderProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIImageButton senderProfile;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UITextBox sendContent;
    }
}
