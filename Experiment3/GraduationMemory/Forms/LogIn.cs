using ClassLibrary;
using Forms;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainForm
{
    public partial class LogIn : UIForm
    {
        public LogIn()
        {
            InitializeComponent();
            uiLabel1.ForeColor = Color.White;
            uiLabel2.ForeColor = Color.White;
            PasswordCheckBox.ForeColor = Color.White;
            pwdTextBox.PasswordChar = '*';
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            char c = new char();
            if (PasswordCheckBox.Checked)
            {
                pwdTextBox.PasswordChar = c;
            }
            else
            {
                pwdTextBox.PasswordChar = '*';
            }
        }
        public List<User> QueryUserByUserId(string stuid)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                  .Where(user => user.UserID.Equals(stuid))
                  .ToList();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (stuidTextBox.Text == "")
            {
                RemindLabel.Text = "用户名/ID不能为空";
                RemindLabel.ForeColor = Color.Red;
            }
            else if (pwdTextBox.Text == "")
            {
                RemindLabel.Text = "密码不能为空";
                RemindLabel.ForeColor = Color.Red;
            }
            else
            {
                string stuid = stuidTextBox.Text;
                List<User> users = QueryUserByUserId(stuidTextBox.Text);
                if (users.Count == 0)
                {
                    RemindLabel.Text = "登陆失败，用户名不存在";
                    RemindLabel.ForeColor = Color.Red;
                }
                else if (users[0].UserPassword != pwdTextBox.Text)
                {
                    RemindLabel.Text = "登陆失败，密码错误，请重新输入";
                    RemindLabel.ForeColor = Color.Red;
                }
                else
                {

                    RemindLabel.Text = "登陆成功";
                    RemindLabel.ForeColor = Color.Green;
                    ThemeForm themeForm = new ThemeForm(users[0]);
                    this.Hide();
                    themeForm.ShowDialog();
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
    }
}
