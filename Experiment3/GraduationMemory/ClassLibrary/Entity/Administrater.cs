using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Administrater
    {
        public string AdministraterID { get; set; }
        public string AdministraterName { get; set; }
        public string AdministraterPassword { get; set; }
        public string AdministraterTele { get; set; }
        public Blob AdministraterProfile { get; set; }
        public string AdministraterAddress { get; set; }

        public Administrater()
        {

        }
        public Administrater(string id, string name, string password, string tele, Blob profile, string address)
        {
            AdministraterID = id;
            AdministraterName = name;
            AdministraterPassword = password;
            AdministraterTele = tele;
            AdministraterProfile = profile;
            AdministraterAddress = address;
        }
    }
}
