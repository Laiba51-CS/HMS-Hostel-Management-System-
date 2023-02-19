using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.BL;
using System.IO;
using HMS.DL;
using HMS.UI;


namespace HMS.DL
{
    class DiscountDL
    {
        public static List<Discount> discountlist = new List<Discount>();
        public static float getdiscountprice(float discountpercent, float totalprice)
        {
            float discountprice = (discountpercent * totalprice) / 100;
            float finalprice = totalprice - discountprice;
            return finalprice;
        }


        public static bool readData(string path)
        {
            string roomstatus;
            int roompayment;
            float Discountpercentage;
            float Discountprice;
            double finalprice;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');
                   
                    roomstatus = splittedRecord[0];
                    roompayment= int.Parse(splittedRecord[1]);
                    Discountpercentage = float.Parse(splittedRecord[2]);
                    Discountprice = float.Parse(splittedRecord[3]);
                    finalprice = double.Parse(splittedRecord[4]);
                  
                    Discount dis = new Discount(roomstatus,roompayment,Discountpercentage, Discountprice,finalprice);
                    addintolist(dis);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeData(string path, Discount ad)
        {

            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(ad.RoomStatus+","+ad.Roompayment+","+ad.Discountpercentage1+","+ad.Discountprice1+","+ad.Finalprice);
            addintolist(ad);
            file.Flush();
            file.Close();
        }
        public static void addintolist(Discount d)
        {
            discountlist.Add(d);
        }
        public static void addingdiscount(float discountpercent, string roomstatus,string path)
        {
            float discountprice;
            double finalprice;
            foreach (Manager m in ManagerDL.managers)
            {
                if (roomstatus == m.RoomStatus)
                {
                   discountprice =( m.Roompayment*discountpercent)/ 100;
                    finalprice = m.Roompayment - discountprice;

                    Discount d = new Discount(m.RoomStatus,m.Roompayment,discountpercent, discountprice, finalprice);
                    storeData(path,d);
                   
                    
                }
            }
        }

        

    }
}
