using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFlatFilesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region init hotels
            var hotels = new List<Hotel>()//new Hotel[]
            {
                new Hotel() {HotelNo = 1, Name = "The Pope", Address = "Vaticanstreet 1  1111 Bishopcity"},
                new Hotel() {HotelNo = 2, Name = "Lucky Star", Address = "Lucky Road 12  2222 Hometown"},
                new Hotel() {HotelNo = 3, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 4, Name = "deLuxeCapital", Address = "Luxury Road 99  4444 Luxus"},
                new Hotel() {HotelNo = 5, Name = "Discount", Address = "Inexpensive Road 7 3333 Cheaptown"},
                new Hotel() {HotelNo = 6, Name = "Prindsen", Address = "Algade 5, 4000 Roskilde"},
                new Hotel() {HotelNo = 7, Name = "Scandic", Address = "Algade 5, 4000 Roskilde"},
            };
            #endregion




        }
    }
}
