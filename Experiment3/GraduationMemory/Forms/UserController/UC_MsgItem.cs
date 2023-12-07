using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Service;
using ClassLibrary;

namespace Forms.UserControls
{
    public partial class UC_MsgItem : UserControl
    {
        /// <summary>
        /// 本窗体总高度
        /// </summary>
        public int HEIGHT = 80;
        /// <summary>
        /// 本窗体总宽度
        /// </summary>
        public int WIDTH = 45;
        /// <summary>
        /// 消息类型
        /// </summary>
        public MessageType messageType;

        public Image senderImage, receiverImage;

        public UC_MsgItem()
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
            this.Paint += Item_Paint;
            //lblContent.Click += lblContent_Click;
        }


        #region 界面重绘

        /// <summary>
        /// 绘制气泡左上角小箭头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_Paint(object sender, PaintEventArgs e)
        {
            //自己发送的消息箭头在右上角
            if (messageType == MessageType.Send)
            {
                Color color = System.Drawing.Color.FromArgb(158, 234, 106);
                panel1.BackColor = color;
                Brush brushes = new SolidBrush(color);
                // 三角形的三个点
                Point[] point = new Point[3];
                point[0] = new Point(WIDTH + 10, 17);
                point[1] = new Point(WIDTH, 17);
                point[2] = new Point(WIDTH, 27);
                e.Graphics.FillPolygon(brushes, point);
                PictureBox picAvatar = new PictureBox()
                {
                    Size = new Size(35, 35),
                    Image = senderImage,
                    Location = new Point(WIDTH + 12, 5),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                this.Controls.Add(picAvatar);
            }
            else
            {

                Color color = System.Drawing.Color.LightGray;
                Brush brushes = new SolidBrush(color);
                Point[] point = new Point[3];
                point[0] = new Point(35, 17);
                point[1] = new Point(45, 17);
                point[2] = new Point(45, 27);
                e.Graphics.FillPolygon(brushes, point);
                PictureBox picAvatar = new PictureBox()
                {
                    Size = new Size(35, 35),
                    Image = receiverImage,
                    Location = new Point(0, 5),
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                this.panel1.Left = 45;
                this.Controls.Add(picAvatar);
            }
        }
        #endregion

        #region 功能操作

        /// <summary>
        /// 设置气泡内容
        /// </summary>
        /// <param name="type">消息类型</param>
        /// <param name="content">消息内容</param>
        public void SetInteractionContent(string content)
        {

            lblContent.Text = content;
            lblContent.Visible = true;
            HEIGHT += lblContent.Height;
            WIDTH += lblContent.Width;
        }

        //设置一个lblContent是否可以点击的函数
        public void islblContentClick(bool isClick)
        {
            lblContent.Enabled = isClick;
        }

        public void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion

        /// <summary>
        /// 消息类型
        /// </summary>
        public enum MessageType
        {
            Send,
            Receive
        }
    }
}