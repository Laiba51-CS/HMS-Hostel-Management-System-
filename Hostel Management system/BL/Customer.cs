using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BL
{
    class Customer:Manager
    {
        private string name;
        private string roomID;
        private int roomnumber;
        private string date;
        public Customer()
        {

        }
        public Customer(string name,string roomID,int roomnumber,string date)
        {
            this.name=name;
            this.roomID=roomID;
            this.roomnumber = roomnumber;
            this.date = date;
        }

        public string Name { get => name; set => name = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public int Roomnumber { get => roomnumber; set => roomnumber = value; }
        public string Date { get => date; set => date = value; }
    }
}
