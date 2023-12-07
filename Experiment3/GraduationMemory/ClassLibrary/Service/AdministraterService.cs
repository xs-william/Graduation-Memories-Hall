using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AdministraterService
    {
        public AdministraterService()
        {
            // 测试数据库使用
            using (var ctx = new SystemContext())
            {
                if (ctx.Administraters.Count() == 0)
                {
                    Blob blob = new Blob();
                    ctx.Administraters.Add(new Administrater("apple", "12", "12", "12", blob, "12"));
                    ctx.SaveChanges();
                }
            }
        }

        public void AddAdministrater(Administrater administrater)
        {
            using (var ctx = new SystemContext())
            {
                if (administrater == null) { return; }
                ctx.Administraters.Add(administrater);
                ctx.SaveChanges();
            }
        }
        public void DeleteAdministrater(Administrater administrater)
        {
            using (var ctx = new SystemContext())
            {
                var administrater1 = ctx.Administraters
                    .SingleOrDefault(s => s.AdministraterID == administrater.AdministraterID);

                if (administrater1 == null) { return; }
                ctx.Administraters.Remove(administrater1);
                ctx.SaveChanges();
            }
        }
        public void ModifyAdministrater(Administrater administrater)
        {
            DeleteAdministrater(administrater);
            AddAdministrater(administrater);
        }
        public List<Administrater> GetAllAdministrater()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Administraters
                    .ToList();
            }
        }
        public List<Administrater> GetAdministraterByName(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Administraters
                    .Where(s => s.AdministraterName == name)
                    .ToList();
            }
        }
        public List<Administrater> GetAdministraterByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Administraters
                    .Where(s => s.AdministraterID == id)
                    .ToList();
            }
        }
    }
}
