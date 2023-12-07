using ClassLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class CommandChat : UserControl
    {
        //把发送消息发送者传入
        User user;
        string imageID;

        public CommandChat(User user, string content)
        {
            InitializeComponent();
            this.user = user;

            //绑定头像
            DisPlayImage(user.UserID);

            name.Text = user.UserName;
            sendContent.Text = content;
            //senderProfile.Image = Image.FromFile("../picture/profile.jpg");

        }



        private void DisPlayImage(string senderID)
        {
            byte[] imageData = null;
            using (var ctx = new SystemContext())
            {
                var result = ctx.SaveImages
                        .SingleOrDefault(s => s.UploaderID == senderID);
                if (result != null)
                {
                    imageData = result.ImageData;
                }

            }

            if (imageData != null)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    senderProfile.Image = image;
                }
            }
            else
            {
                // 如果未找到对应的图片数据，可以显示默认的图片
                senderProfile.Image = Image.FromFile("../picture/profile.jpg");
                //MessageBox.Show("请点击设置头像");
            }

        }

        private void senderProfile_Click(object sender, EventArgs e)
        {
            /*UserService userService = new UserService();

            if (userService.IsExistImage('u' + user.UserID))
            {
                userService.DeleteUserImage('u' + user.UserID);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                senderProfile.Image = Image.FromFile(imagePath);
                SaveImageToDatabaseByPath(imagePath, user.UserID);
            }
            this.Invalidate();*/
        }
    }
}
