using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do { 
            Console.WriteLine("Nhap so nguyen duong: ");
            n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Nhap lai (khong duoc  < 0):");
                }
            }while (n < 0) ;

            int tong = 0;

            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            Console.WriteLine("Tong tu 1 den {0} la: {1}", n, tong);

            Console.ReadLine();
        }
    }
}
