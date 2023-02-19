using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using HMS.DL;
using HMS.UI;
using System.IO;

namespace HMS.DL
{
    class AdminDL
    {
      public static  int count = 0;
        public static List<Admin> adminsList = new List<Admin>();

        public static bool readData(string path)
        {

            string Id;
            string users;
            string Password;
            string role;
            double phoneno;
            int salary;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    Id = splittedRecord[0];
                    users = splittedRecord[1];
                    Password = splittedRecord[2];
                    role = splittedRecord[3];
                    phoneno = double.Parse(splittedRecord[4]);
                    salary = int.Parse(splittedRecord[5]);
                    Admin user = new Admin(Id, users, Password, role, phoneno, salary);
                    addadmindata(user);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void removeruser()
        {
            string Id = "";

            while (Id != "n")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\tEnter the ID to remove data\t<<<<<<press n if you dont want to end the removing process>>>>>>");
                Console.Write("\t==>"); Id = Console.ReadLine();
                for (int i = 0; i < adminsList.Count; i++)
                {
                    if (adminsList[i].Id1 == Id)
                    {
                        adminsList.RemoveAt(i);
                        Console.WriteLine("\t==========> REMOVED SUCCESSFULLY <==========");
                    }
                }
            }

        }
        public static void changepassowrd(string Id,string pass)
        {
           
            for (int i = 0; i <adminsList.Count; i++)
            {
                if (adminsList[i].Id1 == Id)
                {

                    adminsList[i].Password1 = pass;
                  
                       
                    Console.WriteLine("\t==========> CHANGED SUCCESSFULLY <==========");
                  
                }
            }
         

        }
        public static void changesalary(string Id, int salary)
        {
            for (int i = 0; i < adminsList.Count; i++)
            {
                if (adminsList[i].Id1 == Id)
                {

                      adminsList[i].Salary = salary;
    
                    Console.WriteLine("\t==========> CHANGED SUCCESSFULLY <==========");

                }
            }
        }
        public static void addadmindata(Admin ad)
        {
            adminsList.Add(ad);
            count++;
        }

        public static void storeData(string path,Admin ad)
        {

            StreamWriter file = new StreamWriter(path, true);
        
                file.WriteLine(ad.Id1 + "," +ad.Users + "," + ad.Password1 + "," + ad.Role + "," + ad.Phoneno + "," + ad.Salary);
              addadmindata(ad);
            file.Flush();
            file.Close();
        }

       
    }
}

