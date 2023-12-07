using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class MessageService
    {

        //单例模式
        private static MessageService instance = null;
        private static readonly object instanceLock = new object();

        private MessageService() { }

        public static MessageService GetInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MessageService();
                    }
                    return instance;
                }
            }
        }

        public List<Message> Messages
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.Messages
                        .ToList<Message>();
                }
            }
        }

        public List<Message>? GetMessage(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Messages
                    .Where(o => o.BoxId == id)
                    .ToList<Message>();

            }
        }

        public void AddMessage(Message message)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Entry(message).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void RemoveMessage(string id)
        {
            using (var ctx = new SystemContext())
            {
                var message = ctx.Messages.SingleOrDefault(o => o.Id == id);
                if (message == null) return;
                ctx.Messages.Remove(message);
                ctx.SaveChanges();
            }
        }

    }
}
