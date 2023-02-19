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
    class CustomerUI
    {
        public static bool flag = true;
        public static int customermenu()
        {

            int option;
            Console.Clear();
            HeaderUI.header();
            HeaderUI.header2("CUSTOMER MENU");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t\t\t1==>Make Reservation............");
            Console.WriteLine("\t\t\t\t2==>Delete Reservation..........");
            Console.WriteLine("\t\t\t\t3==>Print Bill..................");
            Console.WriteLine("\t\t\t\t4==>View Discount...............");
            Console.WriteLine("\t\t\t\t5==>See Facilites...............");
            Console.WriteLine("\t\t\t\t6==>Exit........................");

            Console.WriteLine("\t\t-------------------------ENTER YOUR OPTION----------------------------");
            Console.Write("\t\t--->"); option = int.Parse(Console.ReadLine());
            return option;
        }
        public static void discountdetails()
        {
            Console.Clear();
            HeaderUI.header2("DISCOUNT ON ROOMS");
            Console.WriteLine();
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\t\tROOM-STATUS\t\tROOM-PAYMENTS\t\t%DISCOUNT%\t\tFINAL-PRICE");
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine("");
            foreach (Discount d in DiscountDL.discountlist)
            {
                Console.WriteLine("\t\t" + d.RoomStatus + "\t\t\t" + d.Roompayment + "Rs" + "\t\t\t" + d.Discountpercentage1 + "%" + "\t\t\t" + d.Finalprice + "/-");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t----------------->>    THIS DISCOUNT IS ON PER ROOM ACCORDING TO THE MANAGER  <<-------------------------");



        }
        public static void viewReservation()
        {
            Console.Clear();
            Console.WriteLine();
            HeaderUI.header2("VIEW RESERVATION");
            Console.WriteLine();
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tCUSTOMERNAME\tROOM-ID\tTOTALROOMS\tDAYS");
            Console.WriteLine("\t___________________________________________________________________________________________________________");

            foreach (Customer c in CustomerDL.customers)
            {
                Console.WriteLine(c.Name + "\t" + c.RoomID + "\t\t" + c.Roomnumber + "\t\t" + c.Date);
            }



        }
        public static Customer makereservation()
        {
            string name="";
            string roomID="";
            int roomnumber=0;
            string date="";
            
            try
            {


              
                Console.Clear();
                ManagerUI.viewRoomRecords();
                HeaderUI.header2("MAKE RESERVATION");
                Console.WriteLine("\t\t");
                Console.WriteLine("\t\t");
                Console.WriteLine("\t\t\tEnter Your Name");
                Console.Write("\t\t"); name = Console.ReadLine();
                Console.WriteLine("\t\t\tEnter the RoomID............");
                Console.Write("\t\t"); roomID = Console.ReadLine();
                Console.WriteLine("\t\t\tEnter how many rooms you want to buy..........");
                Console.Write("\t\t"); roomnumber = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t\thow many days you want to live ?");
                Console.Write("\t\t"); date = Console.ReadLine();
              
            }
              
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Customer cust = new Customer(name, roomID, roomnumber, date);

            return cust;

        }

        public static string  printbill()
        {
            Console.Clear();
            HeaderUI.header2("PRINTING BILL");

            string name="";
            int payment = 0;

            if (CustomerDL.customers != null)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t\t\tEnter your name... ");
                Console.Write("\t\t"); name = Console.ReadLine();
                foreach (Customer c in CustomerDL.customers)
                {
                    if (c.Name == name)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine();
                        HeaderUI.header2("PRINTING BILL");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t\t Your name...   \t\t" + c.Name);
                        foreach (Manager m in ManagerDL.managers)
                        {
                            if (c.RoomID == m.RoomID)
                            {
                                Console.WriteLine("\t\t\t\t\t Your Roomstatus..  \t\t" + m.RoomStatus);
                                Console.WriteLine("\t\t\t\t\t Your total ROOms are..\t\t " + c.Roomnumber);
                                payment = m.Roompayment * c.Roomnumber;
                                Console.WriteLine();
                                Console.WriteLine("\t\t\t\t total payment for room..\t" + payment);
                                Console.WriteLine("\t\t\t___________________________________________________________");

                                foreach (Discount d in DiscountDL.discountlist)
                                {

                                    if (m.RoomStatus == d.RoomStatus)
                                    {
                                        Console.WriteLine();
                                        double price = DiscountDL.getdiscountprice(d.Discountpercentage1, m.Roompayment);
                                        Console.WriteLine("\t\t\t\t------------Discountpercentage" + d.Discountpercentage1 + "%-------------");
                                        Console.WriteLine("\t\t\t\tAfter discount the you have to pay :" + price * c.Roomnumber);
                                        Console.WriteLine("\t\t\t-----------------------------------------------------------");


                                    }
                                }
                                Console.WriteLine();
                                 Console.WriteLine("\t                 ===========>NO discount is Applied<=======================");
                            }

                        }
                        char option;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\t\t\t Want to confirm the Reservation (y/n) ");
                        Console.WriteLine();
                        Console.WriteLine("\t\t======================>After this you cannot delete the reservation <=======================");
                        Console.Write("\t\t"); option = char.Parse(Console.ReadLine());
                        if (option == 'y')
                        {
                            Console.WriteLine("\t\t\t****************** RESERVED SUCCESSFULLY******************");
                        }

                         if (option == 'n')
                        {

                            Console.WriteLine();
                            Console.WriteLine("\t\t======================>AGAIN MAKE RESERVATION <=======================");
                            Console.WriteLine();
                            flag = false;

                        }
                    }
                }
            }
            foreach (Customer c in CustomerDL.customers)
            {
                if (c.Name != name)
                {


                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t_________________________________________________________________________________________");
                    Console.WriteLine();
                    Console.WriteLine("\t\t======================>FIRST MAKE RESERVATION  THEN YOU CAN PRINT BILL <=======================");
                    Console.WriteLine();
                    Console.WriteLine("\t\t\t_____________________________________________________________________________________");
                }
            }
            return name;
        }
    }
}
                


                    
                