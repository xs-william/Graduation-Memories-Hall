using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Interaction
    {

        public string InteractionID { get; set; }
        public string InteractionContent { get; set; }
        public string InteractionSenderID { get; set; }//发送者的用户ID，和User连接，1对1
        public string InteractionReceiverID { get; set; }//接收者的用户ID，和User连接，1对1
        public DateTime InteractionTime { get; set; }
        public bool InteractionStatus { get; set; }//未已读
        public string InteractionType { get; set; } //消息类型

        public Interaction()
        {

        }
        public Interaction(string interactionid, string content, string senderid, string receiverid, DateTime time)
        {
            InteractionID = interactionid;
            InteractionContent = content;
            InteractionSenderID = senderid;
            InteractionReceiverID = receiverid;
            InteractionTime = time;
        }
    }
}
