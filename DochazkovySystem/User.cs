using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DochazkovySystem
{
    public class User
    {
        public string Name { get; set; }
        public string Surnname { get; set; }
        public int User_number { get; set; }

        public User(string name, string surnname, int user_number) 
        {
            Name = name;
            Surnname = surnname;
            User_number = user_number;
        }


    }
}
