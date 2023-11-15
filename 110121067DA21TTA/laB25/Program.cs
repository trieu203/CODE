using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laB25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong:");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Nhap lai (khong duoc < 0):");
                }
            } while (n < 0);
            double tong = 0;

            for(int i = 1; i <=n; i++)
            {
                tong += 1.0 / (Math.Pow(2, i));
            }

            Console.WriteLine("Tong la: {0}", tong);

            Console.ReadKey();
        }
    }
}
