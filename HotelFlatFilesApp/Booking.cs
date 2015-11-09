using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFlatFilesApp
{
    class Booking
    {

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
