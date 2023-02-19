using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using HMS.DL;
using HMS.UI;


namespace HMS
{
    class AdminUI
    {
      
        public static char Adminmenu()
        {
            char op;
            Console.Clear();
            HeaderUI.header();
            HeaderUI.header2("ADMIN MENU");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t1==>Add Users in Application............");
            Console.WriteLine("\t\t2==>View users .........................");
            Console.WriteLine("\t\t3==>Remove  users.......................");
            Console.WriteLine("\t\t4==>Manage Hotel .......................");
            Console.WriteLine("\t\t5==>Exit ...............................");
            Console.WriteLine("\t\t--------ENTER YOUR OPTION-------");
            Console.Write("\t\t");op =char.Parse(Console.ReadLine());
            return op;
        }
        public static void view()
        {
          if (AdminDL.adminsList != null)
            {
                Console.Clear();
                HeaderUI.header2("SHOWING USERS DATA");
                Console.WriteLine();
                Console.WriteLine("\t___________________________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\tUSERS-IDS\tUSERS-NAMES\tPASSWORDS\tROLES\t\tPHONENUMBERS\t\tSALARIES");
                Console.WriteLine("\t___________________________________________________________________________________________________________");
                foreach (Admin user in AdminDL.adminsList)
                {

                    Console.WriteLine("\t==>" + user.Id1 + "\t" + user.Users + "\t\t" + user.Password1 + "\t\t" + user.Role + "\t\t" + user.Phoneno + "\t\t" + user.Salary);

                }
            }
            else
            {
                Console.WriteLine("\t\t\t==>Enter some data to view !...");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t==========> IF YOU WANT TO ADD NEW USER YOU CAN GO BACK TO PREVIOUS MENU <============");

        }
        public static char managehotel()
        {
            char op;
            Console.Clear();
            HeaderUI.header();
            HeaderUI.header2("MANAGE HOTEL");         
            Console.WriteLine("\t\t<<<<<<<<<<<<<<<<<<You can Just change Password and Salary>>>>>>>>>>>>>>>>");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t>>1.Change Passwords ...........");
            Console.WriteLine("\t\t>>2.Change Salary...............");
            Console.WriteLine("\t\t>>3.Discount Details............");
            Console.WriteLine("\t\t>>4.Previous Menu...............");

            Console.WriteLine("\t");op = char.Parse(Console.ReadLine());
            Console.WriteLine();
            return op;

        }

        public static Admin usersinformation()
        {
            string Id;
            string users;
            string Password;
            string role;
            double phoneno;
            int salary;
            Console.Clear();
            HeaderUI.header();
            HeaderUI.header2("ADDING DATA OF USERS");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t<<Enter the ID...........");
            Console.Write("\t*\t");Id = Console.ReadLine();
            Console.WriteLine("\t\t\t<<Enter the UserName.....");
            Console.Write("\t*\t"); users = Console.ReadLine();
            Console.WriteLine("\t\t\t<<Enter the Password.....");
            Console.Write("\t*\t"); Password = Console.ReadLine();
            Console.WriteLine("\t\t\t<<Enter the Role.........");
            Console.Write("\t*\t"); role = Console.ReadLine();
            Console.WriteLine("\t\t\t<<Enter the Phonenumber.........");
            Console.Write("\t*\t"); phoneno = double.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\t<<Enter the Salary.......");
            Console.Write("\t*\t"); salary = int.Parse(Console.ReadLine());
            Admin admins = new Admin(Id, users, Password, role, phoneno, salary);
            return admins;

        }
        public static string takeID()
        {
            string Id = "";
            Console.Clear();
            HeaderUI.header2("MANAGE HOTEL");
            Console.WriteLine();
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tUSERS-IDS\tUSERS-NAMES\tPASSWORDS\tROLES\t\tPHONENUMBERS\t\tSALARIES");
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            foreach (Admin user in AdminDL.adminsList)
            {

                Console.WriteLine("\t==>" + user.Id1 + "\t" + user.Users + "\t\t" + user.Password1 + "\t\t" + user.Role + "\t\t" + user.Phoneno + "\t\t" + user.Salary);

            }
        
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tEnter the ID to change Password\t<<<<<<press n for stoping this function>>>>>>");
            Console.Write("\t==>"); Id = Console.ReadLine();
            return Id;
        }
        public static string takeinput(string Id)
        {
            string password = "";
            if (AdminDL.adminsList != null)
            {
                Console.WriteLine();
                Console.Clear();
                HeaderUI.header2("CHANGING  PASSWORD");
                for (int i = 0; i < AdminDL.adminsList.Count; i++)
                {
                    if (AdminDL.adminsList[i].Id1 == Id)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t >>>>>>>Previous Password  is>>>>>> ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t\t\t" + AdminDL.adminsList[i].Password1);
                        Console.WriteLine("\t___________________________________________________________________________________________________________");
                        Console.WriteLine("\t\t==>Enter the New Password");
                        Console.Write("\t"); password = Console.ReadLine();

                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t<<<<<<<<<<Enter Some data to change salary>>>>>>>>> ");
            }
            return password;


        }
       
        public static int takeSalary()
        {
            int Salary=0;
            if (AdminDL.adminsList != null)
            {   
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t==>Enter the New Salary");
                Console.Write("\t"); Salary = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t<<<<<<<<<<Enter Some data to change salary>>>>>>>>> ");
            }
            return Salary;

        }

    }

}
