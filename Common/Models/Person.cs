using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
   public class Person
    {
        private int id;
        private string name;
        private string surname;
        private string password;

        public Person()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
