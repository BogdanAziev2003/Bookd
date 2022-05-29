using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryApp
{
    class User
    {
        public string Name;
        public string Surname;
        public string UserName;
        public bool Reserv;
        public bool Took;
        public User(string name, string surname, string username, bool reserv, bool took)
        {
            this.Name = name;
            this.Surname = surname;
            this.UserName = username;
            this.Reserv = reserv;
            this.Took = took;
        }
        public User()
        {

        }
        public User(string name, string surname, string username)
        {
            this.Name = name;
            this.Surname = surname;
            this.UserName = username;
        }
    }
}
