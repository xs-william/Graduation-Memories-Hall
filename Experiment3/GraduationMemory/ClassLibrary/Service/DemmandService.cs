using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DemmandService
    {
        public DemmandService() { }

        public void AddDemmand(Demmand demmand)
        {
            using (var ctx = new SystemContext())
            {
                if (demmand == null) { return; }
                ctx.Demmands.Add(demmand);
                ctx.SaveChanges();
            }
        }
        public void DeleteDemmand(Demmand demmand)
        {
            using (var ctx = new SystemContext())
            {
                var demmand1 = ctx.Demmands
                    .SingleOrDefault(s => s.DemmandID == demmand.DemmandID);

                if (demmand1 == null) { return; }
                ctx.Demmands.Remove(demmand1);
                ctx.SaveChanges();
            }
        }
        public void ModifyDemmand(Demmand demmand)
        {
            DeleteDemmand(demmand);
            AddDemmand(demmand);
        }
        public List<Demmand> GetAllDemmand()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Demmands
                    .ToList();
            }
        }

        public List<Demmand> GetDemmandByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Demmands
                    .Where(s => s.DemmandID == id)
                    .ToList();
            }
        }
        public List<Demmand> GetDemmandByTime(DateTime time)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Demmands
                    .Where(s => s.DemmandDate == time)
                    .ToList();
            }
        }
    }
}
