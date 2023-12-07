namespace MainForm
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            RemindLabel = new Sunny.UI.UILabel();
            PasswordCheckBox = new Sunny.UI.UICheckBox();
            registerBtn = new Sunny.UI.UIButton();
            loginBtn = new Sunny.UI.UIButton();
            pwdTextBox = new Sunny.UI.UITextBox();
            stuidTextBox = new Sunny.UI.UITextBox();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(RemindLabel);
            panel1.Controls.Add(PasswordCheckBox);
            panel1.Controls.Add(registerBtn);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(pwdTextBox);
            panel1.Controls.Add(stuidTextBox);
            panel1.Controls.Add(uiLabel2);
            panel1.Controls.Add(uiLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 401);
            panel1.TabIndex = 0;
            // 
            // RemindLabel
            // 
            RemindLabel.BackColor = Color.Transparent;
            RemindLabel.Font = new Font("微软雅黑", 9F);
            RemindLabel.Location = new Point(168, 213);
            RemindLabel.Name = "RemindLabel";
            RemindLabel.Size = new Size(244, 29);
            RemindLabel.TabIndex = 7;
            RemindLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordCheckBox
            // 
            PasswordCheckBox.BackColor = Color.Transparent;
            PasswordCheckBox.Font = new Font("微软雅黑", 9F);
            PasswordCheckBox.Location = new Point(405, 162);
            PasswordCheckBox.MinimumSize = new Size(1, 1);
            PasswordCheckBox.Name = "PasswordCheckBox";
            PasswordCheckBox.Padding = new Padding(22, 0, 0, 0);
            PasswordCheckBox.Size = new Size(86, 36);
            PasswordCheckBox.TabIndex = 6;
            PasswordCheckBox.Text = "显示密码";
            PasswordCheckBox.CheckedChanged += PasswordCheckBox_CheckedChanged;
            // 
            // registerBtn
            // 
            registerBtn.Font = new Font("Microsoft Sans Serif", 13.7999992F);
            registerBtn.Location = new Point(209, 317);
            registerBtn.MinimumSize = new Size(1, 1);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(125, 44);
            registerBtn.TabIndex = 5;
            registerBtn.Text = "注册";
            registerBtn.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            registerBtn.Click += registerBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Microsoft Sans Serif", 13.7999992F);
            loginBtn.Location = new Point(209, 257);
            loginBtn.MinimumSize = new Size(1, 1);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(125, 44);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "登录";
            loginBtn.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            loginBtn.Click += loginBtn_Click;
            // 
            // pwdTextBox
            // 
            pwdTextBox.DoubleValue = 123456D;
            pwdTextBox.Font = new Font("宋体", 12F);
            pwdTextBox.IntValue = 123456;
            pwdTextBox.Location = new Point(198, 162);
            pwdTextBox.Margin = new Padding(4, 5, 4, 5);
            pwdTextBox.MinimumSize = new Size(1, 16);
            pwdTextBox.Name = "pwdTextBox";
            pwdTextBox.Padding = new Padding(5);
            pwdTextBox.ShowText = false;
            pwdTextBox.Size = new Size(200, 36);
            pwdTextBox.TabIndex = 3;
            pwdTextBox.Text = "123456";
            pwdTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            pwdTextBox.Watermark = "";
            // 
            // stuidTextBox
            // 
            stuidTextBox.Font = new Font("宋体", 12F);
            stuidTextBox.Location = new Point(198, 101);
            stuidTextBox.Margin = new Padding(4, 5, 4, 5);
            stuidTextBox.MaxLength = 13;
            stuidTextBox.MinimumSize = new Size(1, 16);
            stuidTextBox.Name = "stuidTextBox";
            stuidTextBox.Padding = new Padding(5);
            stuidTextBox.ShowText = false;
            stuidTextBox.Size = new Size(200, 36);
            stuidTextBox.TabIndex = 2;
            stuidTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            stuidTextBox.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("Microsoft Sans Serif", 13.7999992F);
            uiLabel2.Location = new Point(123, 162);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(68, 29);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "密码";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 13.7999992F);
            uiLabel1.Location = new Point(123, 103);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(80, 29);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "学号";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogIn
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(558, 436);
            Controls.Add(panel1);
            Name = "LogIn";
            Text = "登录";
            ZoomScaleRect = new Rectangle(19, 19, 800, 450);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Sunny.UI.UICheckBox PasswordCheckBox;
        private Sunny.UI.UIButton registerBtn;
        private Sunny.UI.UIButton loginBtn;
        private Sunny.UI.UITextBox pwdTextBox;
        private Sunny.UI.UITextBox stuidTextBox;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel RemindLabel;
    }
}