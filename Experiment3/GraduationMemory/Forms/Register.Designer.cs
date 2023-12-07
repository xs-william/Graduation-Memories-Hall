namespace Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            uiPanel1 = new Sunny.UI.UIPanel();
            returnButton = new Sunny.UI.UIButton();
            picLabel = new Sunny.UI.UILabel();
            RePasswordCheckBox = new Sunny.UI.UICheckBox();
            PasswordCheckBox = new Sunny.UI.UICheckBox();
            resultLabel = new Sunny.UI.UILabel();
            RegisterBtn = new Sunny.UI.UIButton();
            uiAvatar1 = new Sunny.UI.UIAvatar();
            pwdTextBox2 = new Sunny.UI.UITextBox();
            uiLabel7 = new Sunny.UI.UILabel();
            pwdTextBox = new Sunny.UI.UITextBox();
            uiLabel6 = new Sunny.UI.UILabel();
            teleTextBox = new Sunny.UI.UITextBox();
            IDcardTextBox = new Sunny.UI.UITextBox();
            stuIDTextBox = new Sunny.UI.UITextBox();
            nameTextBox = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(returnButton);
            uiPanel1.Controls.Add(picLabel);
            uiPanel1.Controls.Add(RePasswordCheckBox);
            uiPanel1.Controls.Add(PasswordCheckBox);
            uiPanel1.Controls.Add(resultLabel);
            uiPanel1.Controls.Add(RegisterBtn);
            uiPanel1.Controls.Add(uiAvatar1);
            uiPanel1.Controls.Add(pwdTextBox2);
            uiPanel1.Controls.Add(uiLabel7);
            uiPanel1.Controls.Add(pwdTextBox);
            uiPanel1.Controls.Add(uiLabel6);
            uiPanel1.Controls.Add(teleTextBox);
            uiPanel1.Controls.Add(IDcardTextBox);
            uiPanel1.Controls.Add(stuIDTextBox);
            uiPanel1.Controls.Add(nameTextBox);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(0, 35);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(625, 707);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // returnButton
            // 
            returnButton.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            returnButton.Location = new Point(236, 590);
            returnButton.MinimumSize = new Size(1, 1);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(125, 44);
            returnButton.TabIndex = 20;
            returnButton.Text = "返回登录";
            returnButton.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            returnButton.Click += returnButton_Click;
            // 
            // picLabel
            // 
            picLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            picLabel.Location = new Point(341, 393);
            picLabel.Name = "picLabel";
            picLabel.Size = new Size(125, 29);
            picLabel.TabIndex = 19;
            picLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RePasswordCheckBox
            // 
            RePasswordCheckBox.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RePasswordCheckBox.Location = new Point(453, 340);
            RePasswordCheckBox.MinimumSize = new Size(1, 1);
            RePasswordCheckBox.Name = "RePasswordCheckBox";
            RePasswordCheckBox.Padding = new Padding(22, 0, 0, 0);
            RePasswordCheckBox.Size = new Size(86, 36);
            RePasswordCheckBox.TabIndex = 18;
            RePasswordCheckBox.Text = "显示密码";
            RePasswordCheckBox.CheckedChanged += RePasswordCheckBox_CheckedChanged;
            // 
            // PasswordCheckBox
            // 
            PasswordCheckBox.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCheckBox.Location = new Point(453, 282);
            PasswordCheckBox.MinimumSize = new Size(1, 1);
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.Padding = new Padding(22, 0, 0, 0);
            PasswordCheckBox.Size = new Size(86, 36);
            PasswordCheckBox.TabIndex = 17;
            PasswordCheckBox.Text = "显示密码";
            PasswordCheckBox.CheckedChanged += PasswordCheckBox_CheckedChanged;
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultLabel.Location = new Point(236, 494);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(125, 29);
            resultLabel.TabIndex = 16;
            resultLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterBtn.Location = new Point(236, 526);
            RegisterBtn.MinimumSize = new Size(1, 1);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(125, 44);
            RegisterBtn.TabIndex = 15;
            RegisterBtn.Text = "注册";
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // uiAvatar1
            // 
            uiAvatar1.BackgroundImage = (Image)resources.GetObject("uiAvatar1.BackgroundImage");
            uiAvatar1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            uiAvatar1.Location = new Point(226, 384);
            uiAvatar1.MinimumSize = new Size(1, 1);
            uiAvatar1.Name = "uiAvatar1";
            uiAvatar1.Shape = Sunny.UI.UIShape.Square;
            uiAvatar1.Size = new Size(90, 90);
            uiAvatar1.Symbol = 61846;
            uiAvatar1.SymbolSize = 80;
            uiAvatar1.TabIndex = 14;
            uiAvatar1.Text = "uiAvatar1";
            uiAvatar1.Click += uiAvatar1_Click;
            // 
            // pwdTextBox2
            // 
            pwdTextBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdTextBox2.Location = new Point(226, 340);
            pwdTextBox2.Margin = new Padding(4, 5, 4, 5);
            pwdTextBox2.MinimumSize = new Size(1, 16);
            pwdTextBox2.Name = "pwdTextBox2";
            pwdTextBox2.Padding = new Padding(5);
            pwdTextBox2.ShowText = false;
            pwdTextBox2.Size = new Size(220, 36);
            pwdTextBox2.TabIndex = 10;
            pwdTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            pwdTextBox2.Watermark = "";
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.Location = new Point(123, 347);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(96, 29);
            uiLabel7.TabIndex = 9;
            uiLabel7.Text = "确认密码";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pwdTextBox
            // 
            pwdTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdTextBox.Location = new Point(226, 282);
            pwdTextBox.Margin = new Padding(4, 5, 4, 5);
            pwdTextBox.MinimumSize = new Size(1, 16);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Padding = new Padding(5);
            pwdTextBox.ShowText = false;
            pwdTextBox.Size = new Size(220, 36);
            pwdTextBox.TabIndex = 8;
            pwdTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            pwdTextBox.Watermark = "";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.Location = new Point(155, 289);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(78, 29);
            uiLabel6.TabIndex = 7;
            uiLabel6.Text = "密码";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // teleTextBox
            // 
            teleTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teleTextBox.Location = new Point(226, 227);
            teleTextBox.Margin = new Padding(4, 5, 4, 5);
            teleTextBox.MinimumSize = new Size(1, 16);
            teleTextBox.Name = "teleTextBox";
            teleTextBox.Padding = new Padding(5);
            teleTextBox.ShowText = false;
            teleTextBox.Size = new Size(220, 36);
            teleTextBox.TabIndex = 6;
            teleTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            teleTextBox.Watermark = "";
            // 
            // IDcardTextBox
            // 
            IDcardTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDcardTextBox.Location = new Point(226, 169);
            IDcardTextBox.Margin = new Padding(4, 5, 4, 5);
            IDcardTextBox.MinimumSize = new Size(1, 16);
            IDcardTextBox.Name = "IDcardTextBox";
            IDcardTextBox.Padding = new Padding(5);
            IDcardTextBox.ShowText = false;
            IDcardTextBox.Size = new Size(220, 36);
            IDcardTextBox.TabIndex = 6;
            IDcardTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            IDcardTextBox.Watermark = "";
            // 
            // stuIDTextBox
            // 
            stuIDTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stuIDTextBox.Location = new Point(226, 116);
            stuIDTextBox.Margin = new Padding(4, 5, 4, 5);
            stuIDTextBox.MinimumSize = new Size(1, 16);
            stuIDTextBox.Name = "stuIDTextBox";
            stuIDTextBox.Padding = new Padding(5);
            stuIDTextBox.ShowText = false;
            stuIDTextBox.Size = new Size(220, 36);
            stuIDTextBox.TabIndex = 6;
            stuIDTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            stuIDTextBox.Watermark = "";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(226, 57);
            nameTextBox.Margin = new Padding(4, 5, 4, 5);
            nameTextBox.MinimumSize = new Size(1, 16);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Padding = new Padding(5);
            nameTextBox.ShowText = false;
            nameTextBox.Size = new Size(220, 36);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            nameTextBox.Watermark = "";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.Location = new Point(91, 408);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(142, 29);
            uiLabel5.TabIndex = 4;
            uiLabel5.Text = "学生证正面照";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.Location = new Point(141, 234);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(78, 29);
            uiLabel4.TabIndex = 3;
            uiLabel4.Text = "手机号";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.Location = new Point(123, 176);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(125, 29);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "身份证号";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.Location = new Point(155, 121);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(125, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "学号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.Location = new Point(155, 64);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(125, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "姓名";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Register
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(625, 742);
            Controls.Add(uiPanel1);
            Name = "Register";
            Text = "注册";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UITextBox pwdTextBox2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox pwdTextBox;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox teleTextBox;
        private Sunny.UI.UITextBox IDcardTextBox;
        private Sunny.UI.UITextBox stuIDTextBox;
        private Sunny.UI.UITextBox nameTextBox;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton RegisterBtn;
        private Sunny.UI.UILabel resultLabel;
        private Sunny.UI.UICheckBox RePasswordCheckBox;
        private Sunny.UI.UICheckBox PasswordCheckBox;
        private Sunny.UI.UILabel picLabel;
        private Sunny.UI.UIButton returnButton;
    }
}