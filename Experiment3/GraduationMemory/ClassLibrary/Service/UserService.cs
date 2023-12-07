using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class UserService
    {
        public UserService() { }
        public void AddUser(User user)
        {
            using (var ctx = new SystemContext())
            {
                if (user == null) { return; }
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }
        public void DeleteUser(User user)
        {
            using (var ctx = new SystemContext())
            {
                var user1 = ctx.Users
                    .SingleOrDefault(s => s.UserID == user.UserID);

                if (user1 == null) { return; }
                ctx.Users.Remove(user1);
                ctx.SaveChanges();
            }
        }
        public void ModifyUser(User user)
        {
            DeleteUser(user);
            AddUser(user);
        }

        public List<User> GetAllUser()
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                    .ToList();
            }
        }
        public List<User> GetUserByName(string name)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                    .Where(s => s.UserName == name)
                    .ToList();
            }
        }
        public List<User> GetUserByID(string id)
        {
            using (var ctx = new SystemContext())
            {
                return ctx.Users
                    .Where(s => s.UserID == id)
                    .ToList();
            }
        }
    }
}
