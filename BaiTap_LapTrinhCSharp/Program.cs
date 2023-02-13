using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LapTrinhCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triagle triagle = new Triagle(3, 4, 5);

            if(triagle.checkInput())
            {
                Console.WriteLine("Chu vi tam giác: " + triagle.getperimeter());
                Console.WriteLine("Diện tích tam giác: " + triagle.getArea());
            } else
            {
                Console.WriteLine("Tam giác không hợp lệ");
            }

            Console.ReadKey();
        }
    }
}
