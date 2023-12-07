using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GraduationMessage : MessageTheme
    {
        public GraduationMessage()
        {
            Id = Guid.NewGuid().ToString();
            Themes = "GraduationMessage";
            Boxes = new List<MessageBoxes>();
        }

        public void AddBox(string university, string major)
        {
            if (Boxes == null)
            {
                Boxes = new List<MessageBoxes>();
            }
            // 检查是否存在相同大学和专业的 MessageBox
            if (Boxes.Exists(box => box.University == university && box.Major == major))
            {
                Console.WriteLine("A MessageBox for this university and major already exists.");
                return;
            }

            // 创建新的 MessageBox 对象并加入 GraduationBox 列表中
            Coordinate position = new Coordinate(0.0, 0.0);  // 提供坐标信息
            MessageBoxes newMessageBox = new MessageBoxes(position, university, major);
            Boxes.Add(newMessageBox);

            // 输出提示信息
            Console.WriteLine("MessageBox added successfully.");
        }

        public void DeleteBox(string university, string major)
        {
            if (Boxes == null)
            {
                Boxes = new List<MessageBoxes>();
            }
            // 查找并删除相同大学和专业的 MessageBox
            Boxes.RemoveAll(box => box.University == university && box.Major == major);

            // 检查是否找到并删除了 MessageBox
            if (Boxes.Count > 0)
            {
                Console.WriteLine("MessageBox deleted successfully.");
            }
            else
            {
                Console.WriteLine("No MessageBox found for this university and major.");
            }
        }

        public MessageBoxes GetBox(string university, string major)
        {
            if (Boxes == null)
            {
                Boxes = new List<MessageBoxes>();
            }
            // 查找相同大学和专业的 MessageBox
            MessageBoxes? foundMessageBox = Boxes.Find(box => box.University == university && box.Major == major);

            // 检查是否找到了 MessageBox
            if (foundMessageBox != null)
            {
                return foundMessageBox;
            }
            else
            {
                // 返回一个空的 MessageBox 对象，表示未找到
                Console.WriteLine("No MessageBox found for this university and major.");
                return new MessageBoxes(new Coordinate(0.0, 0.0), "", "");
            }
        }
    }
}
