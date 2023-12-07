namespace MainForm
{
    partial class MessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            InputBox = new Sunny.UI.UIGroupBox();
            CreatDemmand = new Button();
            DemandInput = new Sunny.UI.UIRichTextBox();
            Send = new Sunny.UI.UIButton();
            Emoji = new Button();
            Document = new Button();
            uiButton1 = new Sunny.UI.UIButton();
            panelMessage = new Panel();
            uiPanel2 = new Sunny.UI.UIPanel();
            SelectedMajor = new Sunny.UI.UIComboBox();
            SelectedUniversity = new Sunny.UI.UIComboBox();
            Search = new Sunny.UI.UIButton();
            InputBox.SuspendLayout();
            uiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.BackColor = Color.WhiteSmoke;
            InputBox.Controls.Add(CreatDemmand);
            InputBox.Controls.Add(DemandInput);
            InputBox.Controls.Add(Send);
            InputBox.Controls.Add(Emoji);
            InputBox.Controls.Add(Document);
            InputBox.Controls.Add(uiButton1);
            InputBox.Font = new Font("宋体", 12F);
            InputBox.Location = new Point(0, 650);
            InputBox.Margin = new Padding(0);
            InputBox.MinimumSize = new Size(1, 1);
            InputBox.Name = "InputBox";
            InputBox.Padding = new Padding(0, 32, 0, 0);
            InputBox.Radius = 0;
            InputBox.RectSides = ToolStripStatusLabelBorderSides.Top;
            InputBox.Size = new Size(450, 212);
            InputBox.Style = Sunny.UI.UIStyle.Custom;
            InputBox.TabIndex = 2;
            InputBox.Text = null;
            InputBox.TextAlignment = ContentAlignment.MiddleCenter;
            InputBox.TitleTop = 0;
            // 
            // CreatDemmand
            // 
            CreatDemmand.BackgroundImage = (Image)resources.GetObject("CreatDemmand.BackgroundImage");
            CreatDemmand.BackgroundImageLayout = ImageLayout.Zoom;
            CreatDemmand.FlatAppearance.BorderSize = 0;
            CreatDemmand.FlatAppearance.MouseDownBackColor = Color.Lime;
            CreatDemmand.FlatAppearance.MouseOverBackColor = Color.Transparent;
            CreatDemmand.FlatStyle = FlatStyle.Flat;
            CreatDemmand.ForeColor = Color.Transparent;
            CreatDemmand.Location = new Point(406, 2);
            CreatDemmand.Name = "CreatDemmand";
            CreatDemmand.Size = new Size(32, 30);
            CreatDemmand.TabIndex = 10;
            CreatDemmand.UseVisualStyleBackColor = true;
            CreatDemmand.Click += CreatDemmand_Click;
            // 
            // DemandInput
            // 
            DemandInput.FillColor = Color.White;
            DemandInput.Font = new Font("宋体", 12F);
            DemandInput.Location = new Point(4, 36);
            DemandInput.Margin = new Padding(0);
            DemandInput.MinimumSize = new Size(1, 1);
            DemandInput.Name = "DemandInput";
            DemandInput.Padding = new Padding(2);
            DemandInput.RectSides = ToolStripStatusLabelBorderSides.None;
            DemandInput.ShowText = false;
            DemandInput.Size = new Size(442, 131);
            DemandInput.Style = Sunny.UI.UIStyle.Custom;
            DemandInput.TabIndex = 3;
            DemandInput.TextAlignment = ContentAlignment.TopLeft;
            DemandInput.TextChanged += DemandInput_TextChanged_1;
            // 
            // Send
            // 
            Send.Font = new Font("宋体", 12F);
            Send.Location = new Point(343, 170);
            Send.MinimumSize = new Size(1, 1);
            Send.Name = "Send";
            Send.Size = new Size(95, 34);
            Send.Style = Sunny.UI.UIStyle.Custom;
            Send.TabIndex = 9;
            Send.Text = "发送(S)";
            Send.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Send.Click += Send_Click;
            // 
            // Emoji
            // 
            Emoji.BackgroundImage = (Image)resources.GetObject("Emoji.BackgroundImage");
            Emoji.BackgroundImageLayout = ImageLayout.Zoom;
            Emoji.FlatAppearance.BorderSize = 0;
            Emoji.FlatAppearance.MouseDownBackColor = Color.Lime;
            Emoji.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Emoji.FlatStyle = FlatStyle.Flat;
            Emoji.ForeColor = Color.Transparent;
            Emoji.Location = new Point(12, 3);
            Emoji.Name = "Emoji";
            Emoji.Size = new Size(32, 30);
            Emoji.TabIndex = 7;
            Emoji.UseVisualStyleBackColor = true;
            Emoji.Click += Emoji_Click;
            // 
            // Document
            // 
            Document.BackgroundImage = Forms.Properties.Resources.file;
            Document.BackgroundImageLayout = ImageLayout.Zoom;
            Document.FlatAppearance.BorderSize = 0;
            Document.FlatAppearance.MouseDownBackColor = Color.Lime;
            Document.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Document.FlatStyle = FlatStyle.Flat;
            Document.ForeColor = Color.Transparent;
            Document.Location = new Point(60, 2);
            Document.Name = "Document";
            Document.Size = new Size(32, 30);
            Document.TabIndex = 3;
            Document.UseVisualStyleBackColor = true;
            Document.Click += Document_Click;
            // 
            // uiButton1
            // 
            uiButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.Font = new Font("宋体", 12F);
            uiButton1.Location = new Point(338, -445);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(100, 34);
            uiButton1.Style = Sunny.UI.UIStyle.Custom;
            uiButton1.TabIndex = 1;
            uiButton1.Text = "发送(S)";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // panelMessage
            // 
            panelMessage.Location = new Point(0, 100);
            panelMessage.Margin = new Padding(0);
            panelMessage.Name = "panelMessage";
            panelMessage.Size = new Size(450, 550);
            panelMessage.TabIndex = 3;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(SelectedMajor);
            uiPanel2.Controls.Add(SelectedUniversity);
            uiPanel2.Controls.Add(Search);
            uiPanel2.Font = new Font("宋体", 12F);
            uiPanel2.Location = new Point(29, 44);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 35;
            uiPanel2.Size = new Size(393, 44);
            uiPanel2.Style = Sunny.UI.UIStyle.Custom;
            uiPanel2.TabIndex = 5;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // SelectedMajor
            // 
            SelectedMajor.DataSource = null;
            SelectedMajor.FillColor = Color.White;
            SelectedMajor.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SelectedMajor.Items.AddRange(new object[] { "计算机专业", "遥感专业" });
            SelectedMajor.Location = new Point(167, 4);
            SelectedMajor.Margin = new Padding(4, 5, 4, 5);
            SelectedMajor.MinimumSize = new Size(63, 0);
            SelectedMajor.Name = "SelectedMajor";
            SelectedMajor.Padding = new Padding(0, 0, 30, 2);
            SelectedMajor.RectSides = ToolStripStatusLabelBorderSides.None;
            SelectedMajor.Size = new Size(142, 36);
            SelectedMajor.Style = Sunny.UI.UIStyle.Custom;
            SelectedMajor.TabIndex = 4;
            SelectedMajor.Text = "请选择专业";
            SelectedMajor.TextAlignment = ContentAlignment.MiddleLeft;
            SelectedMajor.Watermark = "";
            SelectedMajor.SelectedIndexChanged += SelectedMajor_SelectedIndexChanged;
            // 
            // SelectedUniversity
            // 
            SelectedUniversity.DataSource = null;
            SelectedUniversity.FillColor = Color.White;
            SelectedUniversity.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            SelectedUniversity.Items.AddRange(new object[] { "武汉大学", "华中科技大学" });
            SelectedUniversity.Location = new Point(31, 4);
            SelectedUniversity.Margin = new Padding(4, 5, 4, 5);
            SelectedUniversity.MinimumSize = new Size(63, 0);
            SelectedUniversity.Name = "SelectedUniversity";
            SelectedUniversity.Padding = new Padding(0, 0, 30, 2);
            SelectedUniversity.RectSides = ToolStripStatusLabelBorderSides.None;
            SelectedUniversity.Size = new Size(135, 36);
            SelectedUniversity.Style = Sunny.UI.UIStyle.Custom;
            SelectedUniversity.TabIndex = 3;
            SelectedUniversity.Text = "请选择大学";
            SelectedUniversity.TextAlignment = ContentAlignment.MiddleLeft;
            SelectedUniversity.Watermark = "";
            SelectedUniversity.SelectedIndexChanged += SelectedUniversity_SelectedIndexChanged;
            // 
            // Search
            // 
            Search.Cursor = Cursors.Hand;
            Search.Font = new Font("宋体", 12F);
            Search.Location = new Point(313, 7);
            Search.Margin = new Padding(0);
            Search.MinimumSize = new Size(1, 1);
            Search.Name = "Search";
            Search.Radius = 30;
            Search.Size = new Size(73, 30);
            Search.Style = Sunny.UI.UIStyle.Custom;
            Search.TabIndex = 1;
            Search.Text = "搜索";
            Search.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Search.Click += Search_Click;
            // 
            // MessageForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(450, 862);
            Controls.Add(uiPanel2);
            Controls.Add(panelMessage);
            Controls.Add(InputBox);
            Name = "MessageForm";
            RectColor = Color.Transparent;
            Style = Sunny.UI.UIStyle.Custom;
            Text = "毕业寄语";
            TextAlignment = StringAlignment.Center;
            TitleFont = new Font("宋体", 16.2F, FontStyle.Bold);
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            InputBox.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIGroupBox InputBox;
        private Sunny.UI.UIButton uiButton1;
        private Button Document;
        private Button Emoji;
        private Sunny.UI.UIButton Send;
        private Sunny.UI.UIRichTextBox DemandInput;
        private Panel panelMessage;
        private Button CreatDemmand;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIButton Search;
        private Sunny.UI.UIComboBox SelectedMajor;
        private Sunny.UI.UIComboBox SelectedUniversity;
    }
}