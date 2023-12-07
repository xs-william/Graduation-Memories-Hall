using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ThemeService
    {

        private static ThemeService instance = null;
        private static readonly object instanceLock = new object();

        private ThemeService() { }

        public static ThemeService GetInstance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ThemeService();
                    }
                    return instance;
                }
            }
        }

        public List<MessageTheme> Themes
        {
            get
            {
                using (var ctx = new SystemContext())
                {
                    return ctx.MessageThemes
                        .ToList<MessageTheme>();
                }
            }
        }
        public MessageTheme? GetTheme(string themeName)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.MessageThemes
                    .SingleOrDefault(o => o.Themes == themeName);
            }
        }
        public void AddTheme(MessageTheme theme)
        {
            using (var ctx = new SystemContext())
            {
                ctx.Entry(theme).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();
            }
        }
        public void RemoveTheme(string themeName)
        {
            using (var ctx = new SystemContext())
            {
                var theme = ctx.MessageThemes.SingleOrDefault(o => o.Themes == themeName);
                if (theme == null) return;
                ctx.MessageThemes.Remove(theme);
                ctx.SaveChanges();
            }
        }


    }
}
