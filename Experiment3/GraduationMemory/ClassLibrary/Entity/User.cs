using System.Reflection.Metadata;

namespace ClassLibrary
{
    public class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserTele { get; set; }
        public string UserIdentityCard { get; set; }
        public Blob UseIDCardPhoto { get; set; }
        public Blob UserProfile { get; set; }
        public string UserAddress { get; set; }
        public User()
        {

        }
        public User(string id,string name,string pwd,string tele, string idCard,Blob IDCardPhoto, Blob profile,string address)
        {
            UserID = id;
            UserName = name;
            UserPassword = pwd;
            UserTele = tele;
            UserIdentityCard = idCard;
            UseIDCardPhoto = IDCardPhoto;
            UserProfile = profile;
            UserAddress = address;
        }

    }
}