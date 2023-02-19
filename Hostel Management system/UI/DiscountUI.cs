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
    class DiscountUI
    {
        
        public static void discountdetails()
        {
            Console.Clear();
            HeaderUI.header2("Discount Details");
            Console.WriteLine();
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine("\tROOM-STATUS\t\tROOM-PAYMENTS\t\t%DISCOUNT%\t\t DISCOUNT-PRICE\t\tDISCOUNTED-PRICE");
            Console.WriteLine("\t___________________________________________________________________________________________________________");
            Console.WriteLine("");
           foreach(Discount d in DiscountDL.discountlist)
            {
                Console.WriteLine("\t" + d.RoomStatus + "\t\t\t" + d.Roompayment+"Rs" + "\t\t\t\t" + d.Discountpercentage1+"%" + "\t\t\t" + d.Discountprice1 + "\t\t" + d.Finalprice+"/-");
            }


        }
        public static int takediscount()
        {
            int discountpercentage;
            Console.WriteLine("\t");
            Console.WriteLine("\t\t\tEnter the discount percentage......");
            Console.Write("\t\t");discountpercentage = int.Parse(Console.ReadLine());
            return discountpercentage;

        }
      
        public static string takeroomstatus()
        {
            string status;
            Console.Clear();
            HeaderUI.header2("ADDING DISCOUNTS");
            Console.WriteLine();
            Console.WriteLine("\t");
            ManagerUI.viewRoomRecords();
            Console.WriteLine();
            Console.WriteLine("\t\t\tEnter the Roomstatus");
            Console.Write("\t\t");status = Console.ReadLine();
            return status;
        }




    }
}
