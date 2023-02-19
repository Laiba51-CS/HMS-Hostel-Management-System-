using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using HMS.DL;
using HMS.UI;


namespace HMS.UI
{
    class ManagerUI
    {
        public static int managermenu()
        {
            int option ;
            Console.Clear();
            HeaderUI.header();
            HeaderUI.header2("MANAGER MENU");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t\t\t1==>Manage Employers and Staff............");
            Console.WriteLine("\t\t\t\t2==>Room Management.......................");
            Console.WriteLine("\t\t\t\t3==>Booking & Check-in-system.............");
            Console.WriteLine("\t\t\t\t4==>Financial Report......................");
            Console.WriteLine("\t\t\t\t5==>Add Records...........................");
            Console.WriteLine("\t\t\t\t6==>View Records..........................");
            Console.WriteLine("\t\t\t\t7==>Delete Previous  Records..............");
            Console.WriteLine("\t\t\t\t8==>Invoice System........................");
            Console.WriteLine("\t\t\t\t9==>search room number....................");
            Console.WriteLine("\t\t\t\t10==>Check Available Rooms................");
            Console.WriteLine("\t\t\t\t11==>Exit.................................");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t-------------------------ENTER YOUR OPTION----------------------------");
            Console.Write("\t\t"); option = int.Parse(Console.ReadLine());
            return option;

        }
        public static void booking()
        {
            Console.Clear();
            HeaderUI.header2("BOOKED ROOMS ");
            Console.WriteLine("\t\t1==>View users .........................");
           

        }
        public static int head()
        {
            int op = 0;
            Console.Clear();
            HeaderUI.header2("Manage Employers ");
            Console.WriteLine("\t\t1==>View users .........................");
            Console.WriteLine("\t\t2==>Add Users in Application............");
            Console.Write("\t\t"); op = int.Parse(Console.ReadLine());
            return op;
        }
        public static int roomemnu()
        {
            Console.Clear();
            int op;
            HeaderUI.header2("ROOM MANAGEMENT ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t1==>Add Room Records .........................");
            Console.WriteLine("\t\t\t\t2==>View Room Records............");
            Console.WriteLine("\t\t\t\t3==Delete Room Records............");
            Console.WriteLine("\t\t\t\t4==Add Discounts............");
            Console.WriteLine("\t\t\t\t5==>View Discounts............");
            Console.WriteLine("\t\t\t\t6==>Exit............");

            Console.Write("\t\t"); op = int.Parse(Console.ReadLine());
            return op;

        }
        public static void view()
        {
            if (AdminDL.adminsList != null)
            {
                Console.Clear();
                HeaderUI.header2("SHOWING ADMIN ENTERED DATA");
                Console.WriteLine();
                Console.WriteLine("\t___________________________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\tUSERS-IDS\tUSERS-NAMES\ttROLES\t\tPHONENUMBERS\t\tSALARIES");
                Console.WriteLine("\t___________________________________________________________________________________________________________");
                foreach (Admin user in AdminDL.adminsList)
                {

                    Console.WriteLine("\t==>" + user.Id1 + "\t" + user.Users + "\t\t" + user.Role + "\t\t" + user.Phoneno + "\t\t" + user.Salary);

                }
            }
            else
            {
                Console.WriteLine("\t\t\t==>Enter some data to view !...");
            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("\t\t========> You Can just add the user but you can't do modification in it only Admin can <======="); 
        }

    
        public static void viewRoomRecords()
        {

            Console.Clear();
            if (ManagerDL.managers != null)
            {


                HeaderUI.header2("ROOM  RECORDS");
                Console.WriteLine();
                Console.WriteLine("\t___________________________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine("\tROOM-IDS\tROOM-NUMBER\tTOTALROOMS\tROOM-STATUS\t\tFLOOR-NUMBER\tROOM-PAYMENT\t");
                Console.WriteLine("\t___________________________________________________________________________________________________________");
                foreach (Manager user in ManagerDL.managers)
                {
                      Console.WriteLine("\t==>" + user.RoomID + "\t" + user.RoomNo + "\t\t" + user.Totalnumber + "\t\t" + user.RoomStatus + "\t\t\t" + user.FloorNo + "\t\t" + user.Roompayment + "/-");
                    
                }
            }
            else
            {
                Console.WriteLine("\t\t\t============>Enter some data to view !  <==============...");
            }

        }
        public static string takeroomstatus()
        {
            string roomstat = "";
            Console.Clear();
            HeaderUI.header2("MANAGE HOTEL");
            Console.WriteLine();
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tROOM-IDS\t\tROOM_NUMBER\tROOM_STATUS\tROOMPAYMENT");
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            foreach (Manager user in ManagerDL.managers)
            {

                Console.WriteLine("\t==>" + user.RoomID + "\t" + user.RoomNo + "\t\t" + user.RoomStatus + "\t\t" + user.Roompayment);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tEnter the Room status you want to give discount\t<<<<<<press n for stoping this function>>>>>>");
            Console.Write("\t==>"); roomstat = Console.ReadLine();
            return roomstat;
        }
        public static Manager takeinput()
        {
            string roomID;
            string roomNo;
            int totalnumber;
            string roomStatus;
            string floorNo;
            int roompayment;
           
            Console.Clear();
            Console.WriteLine("\t\t");
            HeaderUI.header2("ROOM MANAGEMENT");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t\tEnter the Room ID....................");
            Console.Write("\t\t==>\t");roomID = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter thr Room Number................");
            Console.Write("\t\t==>\t"); roomNo = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter the Room Status(VIP/NORMAL)....");
            Console.Write("\t\t==>\t"); roomStatus = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter the Total Room Number of Room of this status....");
            Console.Write("\t\t==>\t"); totalnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tEnter the Floor Number...............");
            Console.Write("\t\t==>\t"); floorNo = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter the Room Payment...............");
            Console.Write("\t\t==>\t"); roompayment = int.Parse(Console.ReadLine());
            Manager man = new Manager(roomID, roomNo,totalnumber, roomStatus, floorNo, roompayment);
            return man;
           

           
        }
    }
    
    
    
}
