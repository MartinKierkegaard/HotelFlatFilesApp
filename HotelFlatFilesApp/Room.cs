using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFlatFilesApp
{
    class Room
    {
        //Record layout
        //1-3 RoomNo
        //4-6 Hotelno
        //7-7 RoomType
        //8-12 Price

        public Room()
        {

        }

        public int RoomNo { get; set; }
        public int HotelNo { get; set; }
        public RoomType Types { get; set; }
        public int Price { get; set; }

    }

    enum RoomType
    {
        Single = 1,
        Double = 2,
        Family = 3
    }
}
