using MySql.Data.MySqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using MainForm;
using ClassLibrary.Service;

namespace Forms
{
    public partial class Register : UIForm
    {
        SaveImage thisImage; //用来接收用户提交的学生证正面照
        public Register()
        {
            InitializeComponent();
            pwdTextBox.PasswordChar = '*';
            pwdTextBox2.PasswordChar = '*';
            uiAvatar1.FillColor = Color.Transparent;
        }



        private void uiAvatar1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                uiAvatar1.BackgroundImage = Image.FromFile(imagePath);
                string uploaderID = stuIDTextBox.Text;
                if (uploaderID == "" || uploaderID == null)
                {
                    MessageBox.Show("请先输入上面信息");
                    return;
                }
                ImageService.SaveImageToDatabaseByPath(imagePath, uploaderID, "T_stuCard");
                picLabel.ForeColor = Color.Green;
                picLabel.Text = "上传成功";
            }
        }

        // 判断是否有输入为空的现象
        public bool isNull()
        {
            if (nameTextBox.Text == "" || nameTextBox.Text == null)
            {
                resultLabel.Text = "请输入您的姓名";
                resultLabel.ForeColor = Color.Red;
                return false;
            }
            if (stuIDTextBox.Text == "" || stuIDTextBox.Text == null)
            {
                resultLabel.Text = "请输入您的学号";
                resultLabel.ForeColor = Color.Red;
                return false;
            }
            if (IDcardTextBox.Text == "" || IDcardTextBox.Text == null)
            {
                resultLabel.Text = "请输入您的身份证号";
                resultLabel.ForeColor = Color.Red;
                return false;
            }
            if (teleTextBox.Text == "" || teleTextBox.Text == null)
            {
                resultLabel.Text = "请输入您的手机号";
                resultLabel.ForeColor = Color.Red;
                return false;
            }
            if (pwdTextBox.Text == "" || pwdTextBox.Text == null)
            {
                resultLabel.Text = "请输入您的密码";
                resultLabel.ForeColor = Color.Red;
                return false;
            }
            return true;
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

        private void RePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            char c = new char();
            if (PasswordCheckBox.Checked)
            {
                pwdTextBox2.PasswordChar = c;
            }
            else
            {
                pwdTextBox2.PasswordChar = '*';
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isNull()) return;
                if (pwdTextBox.Text != pwdTextBox2.Text)
                {
                    resultLabel.Text = "两次输入密码不一致";
                    resultLabel.ForeColor = Color.Red;
                    return;
                }
                User auser = new User()
                {
                    UserID = stuIDTextBox.Text,
                    UserName = nameTextBox.Text,
                    UserPassword = pwdTextBox.Text,
                    UserTele = teleTextBox.Text,
                    UserIdentityCard = IDcardTextBox.Text,
                    UseIDCardPhoto = new Blob(),
                    UserProfile = new Blob(),
                    UserAddress = null
                };
                using (var ctx = new SystemContext())
                {
                    ctx.Entry(auser).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                }
                // 上传默认头像
                string picPath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Resources\defaultProfile.png";
                ImageService.SaveImageToDatabaseByPath(picPath, stuIDTextBox.Text, "T_profile");
                resultLabel.Text = "注册成功";
                resultLabel.ForeColor = Color.Green;
            }
            catch //(DbUpdateException ex)
            {
                resultLabel.Text = "用户已存在";
                resultLabel.ForeColor = Color.Red;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.ShowDialog();
        }
    }
}
