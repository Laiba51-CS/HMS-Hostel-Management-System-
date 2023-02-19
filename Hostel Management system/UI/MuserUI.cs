using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using HMS.DL;

namespace HMS.UI
{
    class MuserUI
    {



        public static Muser SignUp()
        {
            string password, username, role;

            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t1==>ENTER USERNAME.......... : ");
            Console.Write("\t\t"); username = Console.ReadLine();
            Console.WriteLine("\t\t1==>ENTER PASSWORD.............. ");
            Console.Write("\t\t"); password = Console.ReadLine();

            

            Muser value = new Muser(username, password, "Customer");

            return value;
        }

        public static string signin()
        {
            string password, username;
            string role="";

            Console.Clear();
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t_____________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t>>>>>>>>>>>>    LOGIN TO CONTINUE THE SYSTEM       >>>>>>>>>>>>>>>>>>");
            Console.WriteLine("\t\t______________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t1==>ENTER USERNAME.......... : ");
            Console.Write("\t\t"); username = Console.ReadLine();
            Console.WriteLine("\t\t1==>ENTER PASSWORD.............. ");
            Console.Write("\t\t"); password = Console.ReadLine();

            foreach (Muser user in MuserDL.UsersList)
            {
                if (user.Username == username && user.Password == password)
                {
                   
                     role= user.Role;
                }
            }

            return role;
        }

        public static char LoginPage()
        {
            Console.Clear();

            char option;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t_____________________________________________________________________________________________");
            Console.WriteLine("");      
            Console.WriteLine(" \t\t\t\t<<<<<<<<<<<<<<<<<Login Page>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine(""); 
            Console.WriteLine("\t\t______________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" \t\t\t\t\t1>>>>>>>>>>Sign In");
            Console.WriteLine(" \t\t\t\t\t2>>>>>>>>>>Sign Up");
            Console.WriteLine(" \t\t\t\t\t3>>>>>>>>>>Exit");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\t\t--------Your Option----- ");
            Console.Write("\t\t\t\t\t"); option = char.Parse(Console.ReadLine());
            return option;
        }

    }
}
