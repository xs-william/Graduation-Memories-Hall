using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //用来保存图像,不要用Image类，会与.NET的Image类冲突
    public class SaveImage
    {
        [Key]
        public string ImageId { get; set; }
        //定义type取值只能为：T_profile,T_item,T_p_id,T_n_id......T_stuCard 学生证照片
        public string Type { get; set; }//图的类型，属于头像，商品，身份证......
        public byte[] ImageData { get; set; }
        public string UploaderID { get; set; }//上传者的ID
        public string ItemID { get; set; }//商品的ID，如果不是商品就为空
        //public ICollection<Repair> Repairs { get; set; } // 导航属性,通过导航属性实现Repair类和SaveImage类中对应属性绑定

        public SaveImage()
        {
            ImageId = Guid.NewGuid().ToString();//每创建一个图像就给它传一个唯一的ID
        }

        //如果不是商品类，则只需要传入空值即可
        public SaveImage(byte[] imageData, string uploaderID, string type, string itemID)
        {
            ImageId = Guid.NewGuid().ToString();//每创建一个图像就给它传一个唯一的ID
            ImageData = imageData;
            UploaderID = uploaderID;
            Type = type;
            ItemID = itemID;
        }
    }
}
