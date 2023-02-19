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
    class ManagerDL
    {
        public static List<Manager> managers = new List<Manager>();
        public static void storeData(string path, Manager man)
        {

            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(man.RoomID + "," + man.RoomNo + "," +man.Totalnumber+","+ man.RoomStatus + "," + man.FloorNo + "," + man.Roompayment);
            addintolist(man);
            file.Flush();
            file.Close();
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
                for (int i = 0; i < managers.Count; i++)
                {
                    if (managers[i].RoomID == Id)
                    {
                        managers.RemoveAt(i);
                        Console.WriteLine("\t==========> REMOVED SUCCESSFULLY <==========");
                    }
                }
            }
        }

        public static bool readData(string path)
        {

           string roomID="";
           string roomNo="";
           string roomStatus="";
           string floorNo;
           int roompayment;
            int totalrooms;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    roomID = splittedRecord[0];
                    roomNo = splittedRecord[1];
                    totalrooms = int.Parse(splittedRecord[2]);
                    roomStatus = splittedRecord[3];
                    floorNo = splittedRecord[4];
                    roompayment = int.Parse(splittedRecord[5]);
                   
                    Manager user = new Manager(roomID, roomNo,totalrooms, roomStatus, floorNo, roompayment);
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
        public static void addintolist(Manager man)
        {
            managers.Add(man);
        }


    }
}
