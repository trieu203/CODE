using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu tinh: ");
            int d = int.Parse(Console.ReadLine());

            int max = a;

            if(b > max)
            {
                max = b;             
            }
            if (c > max)
            {
                max = c;
            }
            if(d>max)
            {
                max = d;
            }
            Console.WriteLine("So lon nhat la: " + max);

            Console.ReadKey();
        }
    }
}
