using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BoxesService
    {

        private static BoxesService instance = null;
        private static readonly object instanceLock = new object();

        private BoxesService() { }

        public static BoxesService GetInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BoxesService();
                    }
                    return instance;
                }
            }
        }

        public List<MessageBoxes> Boxes
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.MessageBoxs
                        .ToList<MessageBoxes>();
                }
            }
        }

        public MessageBoxes? GetBox(string university, string major)
        {
            using (var ctx = new SystemContext())
            {

                var temp = ctx.MessageBoxs
                    .SingleOrDefault(o => o.University.Equals(university) && o.Major.Equals(major));
                if (temp == null)
                {
                    MessageBoxes messageBoxes = new MessageBoxes(new Coordinate(0, 0), university, major);
                    ctx.Entry(messageBoxes).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();
                }
                temp = ctx.MessageBoxs
                    .SingleOrDefault(o => o.University.Equals(university) && o.Major.Equals(major));
                return temp;
            }
        }

        public void AddBox(MessageBoxes box)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Entry(box).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void RemoveBox(string id)
        {
            using (var ctx = new SystemContext())
            {
                var box = ctx.MessageBoxs.SingleOrDefault(o => o.BoxID == id);
                if (box == null) return;
                ctx.MessageBoxs.Remove(box);
                ctx.SaveChanges();
            }
        }
    }
}

