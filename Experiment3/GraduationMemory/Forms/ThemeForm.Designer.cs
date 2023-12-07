namespace Forms
{
    partial class ThemeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeForm));
            GraduationMessage = new PictureBox();
            MemoryMap = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GraduationMessage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MemoryMap).BeginInit();
            SuspendLayout();
            // 
            // GraduationMessage
            // 
            GraduationMessage.BackgroundImage = (Image)resources.GetObject("GraduationMessage.BackgroundImage");
            GraduationMessage.BackgroundImageLayout = ImageLayout.Stretch;
            GraduationMessage.Location = new Point(101, 153);
            GraduationMessage.Name = "GraduationMessage";
            GraduationMessage.Size = new Size(244, 227);
            GraduationMessage.TabIndex = 0;
            GraduationMessage.TabStop = false;
            GraduationMessage.Click += GraduationMessage_Click;
            // 
            // MemoryMap
            // 
            MemoryMap.BackgroundImage = (Image)resources.GetObject("MemoryMap.BackgroundImage");
            MemoryMap.BackgroundImageLayout = ImageLayout.Stretch;
            MemoryMap.Location = new Point(101, 468);
            MemoryMap.Name = "MemoryMap";
            MemoryMap.Size = new Size(244, 213);
            MemoryMap.TabIndex = 1;
            MemoryMap.TabStop = false;
            MemoryMap.Click += MemoryMap_Click;
            // 
            // ThemeForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(450, 862);
            Controls.Add(MemoryMap);
            Controls.Add(GraduationMessage);
            Name = "ThemeForm";
            Text = "主题选择";
            TextAlignment = StringAlignment.Center;
            TitleFont = new Font("宋体", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            ((System.ComponentModel.ISupportInitialize)GraduationMessage).EndInit();
            ((System.ComponentModel.ISupportInitialize)MemoryMap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox GraduationMessage;
        private PictureBox MemoryMap;
    }
}