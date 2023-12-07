using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MemoryMap : MessageTheme
    {
        public MemoryMap()
        {
            Id = Guid.NewGuid().ToString();
            Themes = "MemoryMap";
            Boxes = new List<MessageBoxes>();
        }

        public void AddBox(Coordinate coordinate, string university, string major)
        {
            if (Boxes == null)
            {
                Boxes = new List<MessageBoxes>();
            }
            // 检查是否存在相同坐标的 MessageBox
            if (Boxes.Exists(box => box.Position.Equals(coordinate)))
            {
                Console.WriteLine("A MessageBox already exists at this coordinate.");
                return;
            }

            // 创建新的 MessageBox 对象并加入 MapBoxes 列表中
            MessageBoxes newMessageBox = new MessageBoxes(coordinate, university, major);
            Boxes.Add(newMessageBox);

            // 输出提示信息
            Console.WriteLine("MessageBox added successfully.");
        }

        public void DeleteBox(Coordinate coordinate)
        {
            if (Boxes == null)
            {
                Boxes = new List<MessageBoxes>();
            }
            // 查找并删除相同坐标的 MessageBox
            Boxes.RemoveAll(box => box.Position.Equals(coordinate));

            // 检查是否找到并删除了 MessageBox
            if (Boxes.Count > 0)
            {
                Console.WriteLine("MessageBox deleted successfully.");
            }
            else
            {
                Console.WriteLine("No MessageBox found at this coordinate.");
            }
        }

        public MessageBoxes GetBox(Coordinate coordinate)
        {
            if (Boxes == null)
            {
                Boxes = new List<MessageBoxes>();
            }
            // 查找相同坐标的 MessageBox
            MessageBoxes? foundMessageBox = Boxes.Find(box => box.Position.Equals(coordinate));

            // 检查是否找到了 MessageBox
            if (foundMessageBox != null)
            {
                return foundMessageBox;
            }
            else
            {
                // 返回一个空的 MessageBox 对象，表示未找到
                Console.WriteLine("No MessageBox found at this coordinate.");
                return new MessageBoxes(new Coordinate(0.0, 0.0), "", "");
            }
        }
    }
}
