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
using Forms;
using ClassLibrary;
using Forms.UserControls;
using Sunny.UI;
using ClassLibrary.Service;

namespace MainForm
{

    public partial class MessageForm : UIForm
    {
        User me;
        Image senderImage;

        //单例模式的应用
        public static BoxesService boxesService
        {
            get
            {
                return BoxesService.GetInstance;
            }
        }
        public static MessageService messageService
        {
            get
            {
                return MessageService.GetInstance;
            }
        }
        public static ThemeService themeService
        {
            get
            {
                return ThemeService.GetInstance;
            }
        }



        //不需要接收者，只需要把需求发布出
        public MessageForm(User me)
        {

            SetStyle(
                ControlStyles.UserPaint//使用自定义的绘制方式
                | ControlStyles.ResizeRedraw//当控件大小发生变化时就重新绘制
                | ControlStyles.DoubleBuffer// 双缓冲
                | ControlStyles.SupportsTransparentBackColor//则控件接受 alpha 组件数小于 255 个的 BackColor 来模拟透明度
                | ControlStyles.AllPaintingInWmPaint//禁止擦除背景.则控件忽略窗口消息 WM_ERASEBKGND 以减少闪烁
                | ControlStyles.EnableNotifyMessage// 
                                                   // Enable the OnNotifyMessage event so we get a chance to filter out 
                                                   // Windows messages before they get to the form's WndProc
                | ControlStyles.OptimizedDoubleBuffer//则控件将首先绘制到缓冲区而不是直接绘制到屏幕，这可以减少闪烁
                , true);

            InitializeComponent();
            panelMessage.AutoScroll = true;
            this.me = me;
            senderImage = ImageService.BytesToImage(ImageService.getProfileByID(me.UserID));

            // 手动订阅加载事件
            this.Load += UC_MessageContainer_Load;

        }



        #region 实现发送需求

        /// <summary>
        /// 当前消息气泡起始位置
        /// </summary>
        private int _top = 0;

        /// <summary>
        /// 当前消息气泡高度
        /// </summary>
        private int _height = 0;

        /// <summary>
        /// 显示接收消息
        /// </summary>
        /// <param name="content"></param>
        private void ShowReceiveMessage(ClassLibrary.Message message)
        {
            UC_MsgItem item = new UC_MsgItem
            {
                messageType = UC_MsgItem.MessageType.Receive,
                senderImage = senderImage,
                receiverImage = ImageService.BytesToImage(ImageService.getProfileByID(message.Owner))
            };
            item.SetInteractionContent(message.Content);
            item.islblContentClick(true);

            //计算高度
            item.Top = _top + _height;
            item.Left = 15;

            _top = item.Top;
            _height = item.HEIGHT;

            //滚动条移动最上方，重新计算气泡在panel的位置
            panelMessage.AutoScrollPosition = new Point(0, 0);
            panelMessage.Controls.Add(item);
        }

        /// <summary>
        /// 更新界面，显示发送消息
        /// </summary>
        private async void AddSendMessage(string content)
        {
            #region 发送消息持久化

            //HttpHelper http = new HttpHelper();
            //await http.PostAsync<object>(Api.CreateChatRecord, input);

            //读取用户的选择
            string university = SelectedUniversity.Text;
            string major = SelectedMajor.Text;

            //根据选项选择不同的Box
            BoxesService boxesService = BoxesService.GetInstance;
            //存在则返回，不存在则创建
            MessageBoxes? currentBox = boxesService.GetBox(university, major);

            MessageService messageService = MessageService.GetInstance;

            ClassLibrary.Message message = new ClassLibrary.Message(content, DateTime.Now, me.UserID, true, currentBox.BoxID);
            messageService.AddMessage(message);




            #endregion

            #region 追加气泡

            UC_MsgItem item = new UC_MsgItem
            {
                messageType = UC_MsgItem.MessageType.Send,
                senderImage = senderImage,
                receiverImage = null
            };
            item.SetInteractionContent(content);
            item.islblContentClick(false);

            item.Top = _top + _height;
            item.Left = this.Width - 92 - item.WIDTH;

            _top = item.Top;
            _height = item.HEIGHT;
            panelMessage.AutoScrollPosition = new Point(0, 0);
            panelMessage.Controls.Add(item);

            #endregion
        }

        /// <summary>
        /// 更新界面，初始化显示发送消息
        /// </summary>
        private void ShowSendMessage(ClassLibrary.Message message)
        {
            UC_MsgItem item = new UC_MsgItem
            {
                messageType = UC_MsgItem.MessageType.Send,
                senderImage = senderImage,
                receiverImage = null
            };
            item.SetInteractionContent(message.Content);
            item.islblContentClick(false);

            item.Top = _top + _height;
            item.Left = this.Width - 92 - item.WIDTH;

            _top = item.Top;
            _height = item.HEIGHT;
            panelMessage.AutoScrollPosition = new Point(0, 0);
            panelMessage.Controls.Add(item);
        }

        private void load()
        {
            // 查找当前box下的所有message
            //读取用户的选择
            string university = SelectedUniversity.Text;
            string major = SelectedMajor.Text;

            //根据选项选择不同的Box
            BoxesService boxesService = BoxesService.GetInstance;
            MessageService messageService = MessageService.GetInstance;
            //存在则返回，不存在则创建
            MessageBoxes currentBox = boxesService.GetBox(university, major);
            List<ClassLibrary.Message> currentMessages = messageService.GetMessage(currentBox.BoxID);

            // 根据 时间 属性进行排序  
            //currentMessages.Sort((a, b) => a.Date.CompareTo(b.Date));
            var selfNumber = me.UserID;
            foreach (var item in currentMessages)
            {
                if (item.Owner.Equals(selfNumber))
                {
                    ShowSendMessage(item);
                }
                else
                {
                    ShowReceiveMessage(item);
                }
            }
        }

        private void UC_MessageContainer_Load(object sender, EventArgs e)
        {
            // 查找当前box下的所有message
            //读取用户的选择
            string university = SelectedUniversity.Text;
            string major = SelectedMajor.Text;

            //存在则返回，不存在则创建
            MessageBoxes currentBox = boxesService.GetBox(university, major);
            List<ClassLibrary.Message> currentMessages = messageService.GetMessage(currentBox.BoxID);

            // 根据 时间 属性进行排序  
            //currentMessages.Sort((a, b) => a.Date.CompareTo(b.Date));
            var selfNumber = me.UserID;
            foreach (var item in currentMessages)
            {
                if (item.Owner.Equals(selfNumber))
                {
                    ShowSendMessage(item);
                }
                else
                {
                    ShowReceiveMessage(item);
                }
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (DemandInput.Text == "" || DemandInput.Text == null) return;
            AddSendMessage(DemandInput.Text);
            panelMessage.AutoScrollPosition = new Point(0, this._top);
            DemandInput.Clear();
        }

        #endregion

        private void Document_Click(object sender, EventArgs e)
        {
            //用户选择要发送的文件
            string filepath = string.Empty;
            OpenFileDialog selsectFile = new OpenFileDialog();
            selsectFile.Multiselect = false;//设置是否可以多选
            selsectFile.Title = "请选择要发送的文件";//窗口title
            selsectFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";//筛选文本文件，默认所有
            if (selsectFile.ShowDialog() == DialogResult.OK)
            {
                filepath = selsectFile.FileName;
            }

            // 将图片文件加载到 RichTextBox 控件中
            if (!string.IsNullOrEmpty(filepath))
            {
                // 将图片文件拷贝到剪贴板
                System.Drawing.Image img = System.Drawing.Image.FromFile(filepath);

                // 创建一个新行
                DemandInput.AppendText("\n");

                // 按原比例缩小图片
                Image resizedImage = ResizeImage(img);

                // 将缩小后的图片拷贝到剪贴板
                Clipboard.SetImage(resizedImage);

                // 插入图片到 RichTextBox 控件中
                DemandInput.Paste();
            }

        }

        private void Emoji_Click(object sender, EventArgs e)
        {
            //获取按钮在屏幕上的位置
            Point emojiButtonScreenPos = Emoji.PointToScreen(Point.Empty);
            Emoji emoji = new Emoji(emojiButtonScreenPos.X, emojiButtonScreenPos.Y);
            emoji.Show();
            // 添加事件处理程序
            emoji.EmojiSelected += Emoji_EmojiSelected;
        }

        //设置表情包的显示在textbox中的大小
        private Image ResizeImage(Image img)
        {
            // 计算缩小比例，比如这里设定最大宽度为300
            int maxWidth = 100;
            double ratio = (double)maxWidth / img.Width;
            int newWidth = maxWidth;
            int newHeight = (int)(img.Height * ratio);

            Bitmap result = new Bitmap(img, newWidth, newHeight);

            return result;
        }

        private void Emoji_EmojiSelected(object sender, Image selectedEmoji)
        {
            // 在 RichTextBox 中插入选定的表情图片
            if (selectedEmoji != null)
            {
                // 创建一个新行
                DemandInput.AppendText("\n");

                // 缩小图片
                Image resizedImage = ResizeImage(selectedEmoji);

                // 将图片插入 RichTextBox
                Clipboard.SetImage(resizedImage);
                DemandInput.Paste();
            }
        }

        private void DemandInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        /*//定义一个结构体用来记录传递过来的参数值
        public struct ValueToDemmandForm
        {
            public string DemmandId;
            public string DemmandStatus;
            public string DemmandDate;
            public string DemmandAddr;
            public string DemmandType;
        }*/

        private void CreatDemmand_Click(object sender, EventArgs e)
        {
            /*DemmandConfirm demmandConfirm = new DemmandConfirm(DemandInput.Text, me);
            demmandConfirm.ShowDialog();*/

            /*//参数绑定
            DemmandId = demmandConfirm.valueToDemmandForm.DemmandId;
            DemmandAddr = demmandConfirm.valueToDemmandForm.DemmandAddr;
            DemmandDeadline = demmandConfirm.valueToDemmandForm.DemmandDeadline;
            DemmandStatus = demmandConfirm.valueToDemmandForm.DemmandStatus;
            DemmandType = demmandConfirm.valueToDemmandForm.DemmandType;*/

            /*DemandInput.Text += $"收货地址为：{DemmandAddr} \n";
            DemandInput.Text += $"截止日期为：{DemmandDeadline}\n";
            DemandInput.Text += $"需求类型为：{DemmandType}\n";
            DemandInput.Text += $"详细需求为：";

            ifCreateDemmand = true;*/
        }

        private void SelectedUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectedMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            _top = 0;
            panelMessage.Controls.Clear();
            load();
        }
    }
}
