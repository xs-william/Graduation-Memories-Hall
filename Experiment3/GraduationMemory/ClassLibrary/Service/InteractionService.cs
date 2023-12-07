using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InteractionService
    {
        public InteractionService() { }

        public void AddInteraction(Interaction interaction)
        {
            using (var ctx = new SystemContext())
            {
                if (interaction == null) { return; }
                ctx.Interactions.Add(interaction);
                ctx.SaveChanges();
            }
        }
        public void DeleteInteraction(Interaction interaction)
        {
            using (var ctx = new SystemContext())
            {
                var interaction1 = ctx.Interactions
                    .SingleOrDefault(s => s.InteractionID == interaction.InteractionID);

                if (interaction1 == null) { return; }
                ctx.Interactions.Remove(interaction1);
                ctx.SaveChanges();
            }
        }
        public void ModifyInteraction(Interaction interaction)
        {
            DeleteInteraction(interaction);
            AddInteraction(interaction);
        }
        public List<Interaction> GetAllInteraction()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Interactions
                    .ToList();
            }
        }

        public List<Interaction> GetInteractionByInteractionID(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Interactions
                    .Where(s => s.InteractionID == id)
                    .ToList();
            }
        }

        public List<Interaction> GetInteractionBySenderID(string senderid)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Interactions
                    .Where(s => s.InteractionSenderID == senderid)
                    .ToList();
            }
        }
        public List<Interaction> GetInteractionByReceiverID(string receiverid)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Interactions
                    .Where(s => s.InteractionReceiverID == receiverid)
                    .ToList();
            }
        }

        // 查找两人之间的聊天记录
        public static List<Interaction> GetInteractionsBySenderAndReceiver(string senderid, string receiverid)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Interactions
                    .Where(inter => (inter.InteractionSenderID == senderid && inter.InteractionReceiverID == receiverid)||
                    (inter.InteractionSenderID == receiverid && inter.InteractionReceiverID == senderid))
                    .ToList();
            }
        }
        public List<Interaction> GetCurrentInteractionBySenderAndReceiver(User sender, User receiver)//根据发送者和接收者查找消息，并根据时间从后到先排序
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Interactions
                    .Where(s => s.InteractionSenderID == sender.UserID && s.InteractionReceiverID == receiver.UserID)
                    .OrderByDescending(s => s.InteractionTime)
                    .ToList();
            }
        }
        public List<User> GetSenderIDByReceiver(User receiver)//根据消息的接收者，返回所有给他发过消息的用户
        {
            using (var ctx = new SystemContext())
            {
                var sendersID = ctx.Interactions
                    .Where(s => s.InteractionReceiverID == receiver.UserID)
                    //  .OrderBy(s => s.InteractionTime)
                    .GroupBy(s => s.InteractionSenderID)
                    .Select(s => s.Key)
                    .ToList();
                List<User> Senders = new List<User>();
                List<User> Users = new List<User>();
                UserService userService = new UserService();
                foreach (var senderID in sendersID)//根据每个ID将对应的用户添加到发送者列表中
                {
                    Users = userService.GetUserByID(senderID);
                    Senders.Add(Users[0]);
                }
                return Senders;
            }
        }
    }
}
