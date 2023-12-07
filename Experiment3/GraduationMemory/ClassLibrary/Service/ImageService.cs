using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using MySql.Data.MySqlClient;
using Sunny.UI;
using System.Configuration;
using System.Web;

namespace ClassLibrary.Service
{
    public class ImageService
    {
        public ImageService() { }



        //查询头像是否存在
        public bool IsExistImage(string uploderId, string itemId, string type)
        {
            switch (type)
            {
                case "T_profile":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                            .Where(s => s.Type == type && s.UploaderID == uploderId);
                        if (image == null) { return false; }
                        return true;
                    }
                    break;
                case "T_item":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                            .Where(s => s.Type == type && s.ItemID == itemId);
                        if (image == null) { return false; }
                        return true;
                    }
                    break;
                case "T_p_ID":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                            .Where(s => s.Type == type && s.UploaderID == uploderId);
                        if (image == null) { return false; }
                        return true;
                    }
                    break;
                case "T_n_ID":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                            .Where(s => s.Type == type && s.UploaderID == uploderId);
                        if (image == null) { return false; }
                        return true;
                    }
                    break;
                default://没找到对应的类型
                    return false;
                    break;
            }

        }

        //删除头像
        public void DeleteImage(string uploderId, string itemId, string type)
        {
            switch (type)
            {
                case "T_profile":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                             .SingleOrDefault(s => s.Type == type && s.UploaderID == uploderId);
                        if (image != null)
                        {
                            ctx.SaveImages.Remove(image);
                            ctx.SaveChanges();
                        }
                    }
                    break;
                case "T_item":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                             .SingleOrDefault(s => s.Type == type && s.ItemID == itemId);
                        if (image != null)
                        {
                            ctx.SaveImages.Remove(image);
                            ctx.SaveChanges();
                        }
                    }
                    break;
                case "T_p_ID":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                             .SingleOrDefault(s => s.Type == type && s.UploaderID == uploderId);
                        if (image != null)
                        {
                            ctx.SaveImages.Remove(image);
                            ctx.SaveChanges();
                        }
                    }
                    break;
                case "T_n_ID":
                    using (var ctx = new SystemContext())
                    {
                        var image = ctx.SaveImages
                            .SingleOrDefault(s => s.Type == type && s.UploaderID == uploderId);
                        if (image != null)
                        {
                            ctx.SaveImages.Remove(image);
                            ctx.SaveChanges();
                        }
                    }
                    break;
                default://没找到对应的类型
                    break;
            }

        }

        // 根据id查找头像
        public static byte[] getProfileByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                var result = ctx.SaveImages.Where(s => s.UploaderID == id && s.Type == "T_profile");
                return result.ToList<SaveImage>()[0].ImageData;
            }
        }

        // byte[]转Image
        public static System.Drawing.Image BytesToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }

        // Image转byte[]
        public static byte[] ImageToBytes(System.Drawing.Image image)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                if (format.Equals(ImageFormat.Jpeg))
                {
                    image.Save(ms, ImageFormat.Jpeg);
                }
                else if (format.Equals(ImageFormat.Png))
                {
                    image.Save(ms, ImageFormat.Png);
                }
                else if (format.Equals(ImageFormat.Bmp))
                {
                    image.Save(ms, ImageFormat.Bmp);
                }
                else if (format.Equals(ImageFormat.Gif))
                {
                    image.Save(ms, ImageFormat.Gif);
                }
                else if (format.Equals(ImageFormat.Icon))
                {
                    image.Save(ms, ImageFormat.Icon);
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        // 获取默认头像的byte[]
        public static byte[] GetDefaultProfileBytes()
        {
            string picPath = AppDomain.CurrentDomain.BaseDirectory + @"Resources\defaultProfile.png" ;
            System.Drawing.Image image = System.Drawing.Image.FromFile(picPath);
            return ImageToBytes(image);
        }

        //保存图片函数
        public static void SaveImageToDatabaseByPath(string imagePath, string uploaderID, string type)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(imagePath);
                    img.Save(ms, img.RawFormat);
                    imageData = ms.ToArray();
                }

                //创建一个图像对象用来存放选择的图像
                SaveImage image = new SaveImage()
                {
                    ImageData = imageData,
                    UploaderID = uploaderID,
                    Type = type,
                    ItemID = null
                };

                string connectionString = ConfigurationManager.ConnectionStrings["bidaluo"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    //选择要插入的表和属性
                    string insertQuery = "INSERT INTO SaveImages (ImageId, Type, ImageData, UploaderID, ItemID) VALUES (@imageId,@type,@imageData, @uploaderID,@itemID)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    //添加各个属性对应的值
                    command.Parameters.AddWithValue("@imageId", image.ImageId);
                    command.Parameters.AddWithValue("@type", image.Type);
                    command.Parameters.AddWithValue("@imageData", image.ImageData);
                    command.Parameters.AddWithValue("@uploaderID", image.UploaderID);
                    command.Parameters.AddWithValue("@itemID", image.ItemID);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        
    }
}
