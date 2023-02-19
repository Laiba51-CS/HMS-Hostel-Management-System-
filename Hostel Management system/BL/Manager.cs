using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.BL
{
    class Manager
    {
        private string roomID;
        private string roomNo;
        private int totalnumber;
        private string roomStatus;
        private string floorNo;
        private int roompayment;
       
        public Manager()
        {

        }
        
        public Manager(string roomID,string roomNo,int totalnumber,string roomStatus,string floorNo,int roompayment)
        {
            this.roomID = roomID;
            this.roomNo = roomNo;
            this.totalnumber = totalnumber;
            this.roomStatus = roomStatus;
            this.floorNo = floorNo;
            this.Roompayment = roompayment;
            

        }

        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomNo { get => roomNo; set => roomNo = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
        public string FloorNo { get => floorNo; set => floorNo = value; }
        public int Roompayment { get => roompayment; set => roompayment = value; }
        public int Totalnumber { get => totalnumber; set => totalnumber = value; }
    }
}
