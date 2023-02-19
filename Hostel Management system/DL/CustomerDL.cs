using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using HMS.UI;
using System.IO;



namespace HMS.DL
{
    class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();
        public static void addintolist(Customer c)
        {
            customers.Add(c);
        }
        public static bool readData(string path)
        {
              string name;
             string roomID;
             int roomnumber;
            string date;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    name = splittedRecord[0];
                    roomID = splittedRecord[1];
                    roomnumber =int.Parse(splittedRecord[2]);
                    date = splittedRecord[3];
                   
                    Customer user = new Customer(name, roomID, roomnumber, date);
                    addintolist(user);
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
            
            Console.Clear();
            HeaderUI.header2("DELETING YOUR RESERVATION");
            string Id = "";

            while (Id != "n")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\tEnter the name to remove RESERVATION\t<<<<<<press n if you dont want to end the removing process>>>>>>");
                Console.Write("\t==>"); Id = Console.ReadLine();
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].Name == Id)
                    {
                        customers.RemoveAt(i);
                       
                        storeData("customer.txt", null);
                        Console.WriteLine("\t==========> REMOVED SUCCESSFULLY <==========");
                        
                    }
                }
            }

        }
        public static void removecustomer(string Name)
        {
            if (CustomerUI.flag == false)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].Name == Name)
                    {
                        customers.RemoveAt(i);
                        Console.WriteLine("\t==========> REMOVED SUCCESSFULLY <==========");
                    }
                }

            }
        }

        public static void storeData(string path, Customer ad)
        {

            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(ad.Name + "," + ad.RoomID + "," + ad.Roomnumber + "," + ad.Date );
            addintolist(ad);
            file.Flush();
            file.Close();
        }



    }
}
