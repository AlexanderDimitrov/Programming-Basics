using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15.TorrentPirate
{
    class Program
    {
        static void Main(string[] args)
        {
            double dataToDownload = double.Parse(Console.ReadLine());
            double pricePerMovie = double.Parse(Console.ReadLine());
            double wifePerHour = double.Parse(Console.ReadLine());//<--!
            
            double downloadTime = (((dataToDownload / 2) / 60) / 60);
            double priceForZeWife = downloadTime * wifePerHour;
            double cinemaPrice = (dataToDownload / 1500)*pricePerMovie;
            if(priceForZeWife <= cinemaPrice)
            {
                Console.WriteLine("mall -> {0:F2}lv",priceForZeWife);
            }
            else
            {
                Console.WriteLine("cinema -> {0:F2}lv",cinemaPrice);
            }
          
        }
    }
}
