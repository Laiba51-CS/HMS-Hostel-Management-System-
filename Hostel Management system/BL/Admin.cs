using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BL
{
    class Admin
    {
       private string Id;
        private string users;
        private string Password;
        private string role;
        private double phoneno;
        private int salary;
        public Admin(string Id, string users, string Password, string role, double phoneno, int salary)
        {
            this.Id=Id;
            this.users = users;
            this.Password = Password;
            this.role = role;
            this.phoneno = phoneno;
            this.salary = salary;
           

        }
        public Admin()
        {

        }
        public Admin(string Password)
        {
          
            this.Password = Password;
     
        }

        public string Id1 { get => Id; set => Id = value; }
        public string Users { get => users; set => users = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Role { get => role; set => role = value; }
        public double Phoneno { get => phoneno; set => phoneno = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
