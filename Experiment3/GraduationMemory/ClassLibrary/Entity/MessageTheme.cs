using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public struct Coordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Coordinate(double lat, double lng) { Latitude = lat; Longitude = lng; }
    }
    public class MessageTheme
    {
        [Key]
        public string Id { get; set; }
        public string Themes { get; set; }
        public List<MessageBoxes> Boxes { get; set; }

        public MessageTheme()
        {
        }
        /*
                public void AddBox()
                {
                    // 实现添加 MessageBox 的逻辑
                }

                public void DeleteBox()
                {
                    // 实现删除 MessageBox 的逻辑
                }

                public MessageBox? GetBox()
                {
                    // 实现获取 MessageBox 的逻辑
                    return null; // 替换为实际的返回值
                }
        */
    }
}
