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

namespace Forms
{
    public partial class Emoji : Form
    {
        int CoordinateX, CoordinateY;

        public Emoji(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;

            InitializeComponent();

            //加载表情包界面
            Emoji_Load();
        }

        private void Emoji_Load()
        {
            // 加载表情图片资源
            List<Image> emojis = LoadEmojisFromResources("../../../picture/emoji");

            // 将表情数据加载到 DataGridView 中
            LoadEmojisToDataGridView(emojis);

            // 隐藏行标题和列标题
            EmojisToDataGridView.RowHeadersVisible = false;
            EmojisToDataGridView.ColumnHeadersVisible = false;

            // 设置内容显示的起始位置
            EmojisToDataGridView.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, EmojisToDataGridView.RowTemplate.Height, 0, 0);
            EmojisToDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            //自动适应宽度和高度
            AdjustColumnWidth();
            AdjustDataGridViewHeight();

            //获取界面的高度
            int height = EmojisToDataGridView.Rows.Count * EmojisToDataGridView.RowTemplate.Height;

            //设置窗体的显示位置
            // 设置窗体的起始位置为手动设置
            this.StartPosition = FormStartPosition.Manual;

            // 设置窗体的位置为 (x, y)，这里是示例坐标，你可以根据需要调整
            this.Location = new Point(CoordinateX, CoordinateY - height - 5);

        }

        //自动调整datagridview的宽度
        private void AdjustColumnWidth()
        {
            int numColumns = 6;
            if (EmojisToDataGridView.Columns.Count >= numColumns)
            {
                int availableWidth = EmojisToDataGridView.ClientSize.Width;
                int columnWidth = availableWidth / numColumns;

                for (int i = 0; i < numColumns; i++)
                {
                    EmojisToDataGridView.Columns[i].Width = columnWidth;
                }
            }

        }

        //自适应高度
        private void AdjustDataGridViewHeight()
        {
            int rowHeight = EmojisToDataGridView.RowTemplate.Height;
            int numRows = (EmojisToDataGridView.Rows.Count > 0) ? EmojisToDataGridView.Rows.Count : 1;
            int totalHeight = rowHeight * numRows;

            EmojisToDataGridView.Height = totalHeight;
        }

        private List<Image> LoadEmojisFromResources(string folderPath)
        {

            List<Image> emojis = new List<Image>();

            // 获取文件夹中的所有图片文件
            string[] imageFiles = Directory.GetFiles(folderPath, "*.png"); // 表情图片为 PNG 格式

            foreach (string file in imageFiles)
            {
                try
                {
                    // 从文件加载图片并添加到列表中
                    Image img = Image.FromFile(file);
                    emojis.Add(img);
                }
                catch (Exception ex)
                {
                    // 处理加载图片时可能出现的异常
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }

            return emojis;
        }

        private void LoadEmojisToDataGridView(List<Image> emojis)
        {
            // 设置列数和列宽度
            EmojisToDataGridView.ColumnCount = 6;
            foreach (DataGridViewColumn col in EmojisToDataGridView.Columns)
            {
                col.Width = 50; // 设置列宽度
            }

            // 设置行数
            int rows = emojis.Count % EmojisToDataGridView.ColumnCount == 0 ? (emojis.Count / EmojisToDataGridView.ColumnCount) : (emojis.Count / EmojisToDataGridView.ColumnCount) + 1;
            EmojisToDataGridView.RowCount = rows;

            // 将表情加载到 DataGridView 中
            for (int i = 0; i < emojis.Count; i++)
            {
                int rowIndex = i / EmojisToDataGridView.ColumnCount; // 行索引
                int colIndex = i % EmojisToDataGridView.ColumnCount; // 列索引

                EmojisToDataGridView[colIndex, rowIndex].Value = emojis[i];
            }
        }

        public event EventHandler<Image> EmojiSelected; // 声明事件

        private void EmojisToDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //获取点击的表情包
                Image selectedEmoji = (Image)EmojisToDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // 触发事件，将选定的表情传递回主界面
                EmojiSelected?.Invoke(this, selectedEmoji);

                // 关闭 Emoji 窗体
                this.Close();
            }
        }
    }
}

