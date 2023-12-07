
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SystemContext : DbContext
    {
        public SystemContext() : base("bidaluo")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SystemContext>());
        }
        public DbSet<Administrater> Administraters { get; set; }
        public DbSet<Interaction> Interactions { get; set; }
        public DbSet<Demmand> Demmands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SaveImage> SaveImages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageBoxes> MessageBoxs { get; set; }
        public DbSet<MessageTheme> MessageThemes { get; set; }
    }
}
