using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MessageBoxes
    {
        [Key]
        public string BoxID { get; set; }
        public Coordinate Position { get; set; }
        public string University { get; set; }
        public string Major { get; set; }
        public List<Message> Messages { get; set; }

        public MessageBoxes()
        {
            BoxID = Guid.NewGuid().ToString();
            Messages = new List<Message>();
        }
        public MessageBoxes(Coordinate position, string university, string major)
        {
            BoxID = Guid.NewGuid().ToString();
            Messages = new List<Message>();
            Position = position;
            University = university;
            Major = major;
        }
        public void AddMessage(string content, string owner, bool permit)
        {
            // 获取当前时间
            DateTime currentDate = DateTime.Now;

            // 创建新的消息对象并加入 Messages 列表中
            Message newMessage = new Message(content, currentDate, owner, permit, this.BoxID);
            Messages.Add(newMessage);

            // 输出提示信息
            Console.WriteLine("Message added successfully.");
        }
        public void DeleteMessage(int index)
        {
            // 检查 index 的有效性
            if (index < 0 || index >= Messages.Count)
            {
                Console.WriteLine("Invalid message index.");
                return;
            }

            // 从 Messages 列表中删除指定索引的消息
            Messages.RemoveAt(index);

            // 输出提示信息
            Console.WriteLine("Message deleted successfully.");
        }
        /*        public Message GetMessage(int index)
                {
                    // 检查 index 的有效性
                    if (index < 0 || index >= Messages.Count)
                    {
                        Console.WriteLine("Invalid message index.");
                        // 返回一个空的消息对象，表示无效
                        return new Message("", DateTime.MinValue, "", false);
                    }

                    // 返回指定索引的消息
                    return Messages[index];
                }*/
    }
}
