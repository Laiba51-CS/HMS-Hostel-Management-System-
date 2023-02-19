using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.UI
{
    class HeaderUI
    {
        public static void header()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
              Console.WriteLine("\t\t\t |\\          /|  MMMMM            MMM   SSSSSSSSSSSS   ");
              Console.WriteLine("\t\t\t | \\        / |  MMMM MM        MM MM   SSS            ");
            Console.WriteLine("\t\t\t |  |      |  |  MMMM   MM    MM   MM   SSS            ");
            Console.WriteLine("\t\t\t |  |      |  |  MMMM     MMMM     MM   SSS            ");
            Console.WriteLine("\t\t\t |  *======|  |  MMMM              MM   SSSSSSSSSSSSS    ");
            Console.WriteLine("\t\t\t |  |      |  |  MMMM              MM             sss            ");
            Console.WriteLine("\t\t\t |  |      |  |  MMMM              MM             sss          ");
            Console.WriteLine("\t\t\t ||||      ||||  MMMM              MM   SSSSSSSSSSSSS               ");


        }
        public static void header2(string name)
        {
            
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t --------------------------------------------------------------------------");
            Console.WriteLine("\t\t\t\t\t____________________________");
            Console.WriteLine("\t\t\t\t\t==>"+"\t"+name);
            Console.WriteLine("\t\t\t\t\t____________________________");
            Console.WriteLine("\t\t---------------------------------------------------------------------------");
           
        }
        public static void clear()
        {
            Console.WriteLine("t\t\tpress any key to continue>>>>>>>>>>>");
            Console.ReadKey();
        }
        public static void login()
        {
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t ---------------------------------------------------------------------------------");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t\t\t\t  LOGIN TO CONTINUE THE SYSTEM ");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t");
            Console.WriteLine("\t\t ---------------------------------------------------------------------------------");


        }
    }
}
