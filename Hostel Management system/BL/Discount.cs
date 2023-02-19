using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BL
{
    class Discount:Manager
    {
        private float Discountpercentage;
        private float Discountprice;
        private double finalprice;
        public Discount(float Discountpercentage)
        {
            this.Discountpercentage = Discountpercentage;


        }
        public Discount()
        {

        }
        public Discount(string roomstatus,int roompayment,float Discountpercentage,float Discountprice,double finalprice)
        {
            this.RoomStatus = roomstatus;
            this.Roompayment = roompayment;
            this.Discountpercentage = Discountpercentage;
            this.Discountprice = Discountprice;
            this.finalprice = finalprice;
        }

        public float Discountpercentage1 { get => Discountpercentage; set => Discountpercentage = value; }
        public float Discountprice1 { get => Discountprice; set => Discountprice = value; }
        public double Finalprice { get => finalprice; set => finalprice = value; }
    }
}
