using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User : BaseEntity
    {
        private Profile profile { get; set; }
        public List<Post> Posts { get; set; }

        public string UserName
        {
            get { return profile.UserName; }
            set { profile.UserName = value; }
        }

        public int Gender
        {
            get { return profile.Gender; }
            set { profile.Gender = value; }
        }

        public string Email
        {
            get { return profile.Email; }
            set { profile.Email = value; }
        }

        public int Role
        {
            get { return profile.Role; }
            set { profile.Role = value; }
        }

        public string PasswordHash
        {
            get { return profile.Password; }
            set { profile.Password = value; }
        }

        public string Location
        {
            get { return profile.Location; }
            set { profile.Location = value; }
        }

        public Profile UserData
        {
            get { return profile;}
            set { profile = value; }
        }

        public User(Profile p)
        {
            profile = p;
            profile.UserName = p.UserName;
        }

        public User()
        {
            profile = new Profile();
        }
    }
}
