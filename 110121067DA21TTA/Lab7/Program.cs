using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so km da di:");
            int km = int.Parse(Console.ReadLine());

            int tien = 0;

            if (km == 1)
            {
                tien += 5000;
            }
            else if (km <= 5)
            {
                tien += 5000 + 4500*(km-1);
            }
            else if(km <= 120)
            {
                tien += 5000 + 4500*4 + 3500*(km-5);
            }
            else
            {
                tien += 5000 + 4500 * 4 + 3500 * (km - 5);
                tien = (int)(tien * 0.9);

            }
            Console.WriteLine("So tien phai tra la:{0} ",tien);
            Console.ReadLine();
        }
    }
}
