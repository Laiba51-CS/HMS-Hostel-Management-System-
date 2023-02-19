using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HMS.BL;

namespace HMS.DL
{
    class MuserDL
    {
        public static List<Muser> UsersList = new List<Muser>();

        public static bool readData(string path)
        {

            string name, password, role;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    name = splittedRecord[0];
                    password = splittedRecord[1];
                    role = splittedRecord[2];

                    Muser user = new Muser(name, password, role);
                    AddUserIntoList(user);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path,true);
            
            foreach (Muser user in UsersList)
            {
              
                file.Write(user.Username + "," + user.Password + "," + user.Role);
               
            }

            file.Flush();
            file.Close();
        }

        public static void AddUserIntoList(Muser User)
        {
            UsersList.Add(User);
        }

        public static string isExist(Muser u)
        {
            string role = "";
            foreach (Muser user in UsersList)
            {
                if (user.Username == u.Username && user.Password == u.Password)
                {
                    role = user.Role;
                }
            }
            return role;
        }



    }
}