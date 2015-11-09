using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFlatFilesApp
{
    class Booking
    {
        //Record layout
        //1-3 BookingId
        //4-6 HotelNo
        //7-9 GuestNo
        //10-12 RoomNo
        //13-18 FromDate
        //19-24 ToDate
        
        public Booking()
        {

        }
        

        public int BookingId { get; set; }
        public int HotelNo { get; set; }
        public int GuestNo { get; set; }
        public int RoomNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }


    }
}
