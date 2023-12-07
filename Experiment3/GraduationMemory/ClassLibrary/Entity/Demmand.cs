using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Demmand
    {
        public string DemmandID { get; set; }
        public string DemmandAddress { get; set; }
        public string DemmandContent { get; set; }//订单具体描述
        public string DemmandType { get; set; }//订单类型：外卖、快递、食堂外带等，可改为枚举类
        public string DemmandStatus { get; set; }//订单状态：已发出、已接受、已送达等，可改为枚举类
        public DateTime DemmandDate { get; set; }//下单时间
        public string DemmandDeadline { get; set; }//最晚送达时间
        public string UserID { get; set; }//订单发起者的用户ID，和User连接，多对1

        public Demmand()
        {

        }
        public Demmand(string demmandid, string address, string content, string type, string status, DateTime time, string deadline, string userid)
        {
            DemmandID = demmandid;
            DemmandAddress = address;
            DemmandContent = content;
            DemmandType = type;
            DemmandStatus = status;
            DemmandDate = time;
            DemmandDeadline = deadline;
            UserID = userid;
        }
    }
}
