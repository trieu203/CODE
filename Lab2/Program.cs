using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap phan tu thu nhat : ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap phan tu thu hai : ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap phan tu thu ba : ");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: " + x); 
            }
            else
            {
                double x1 = 0;
                double x2 = 0;
                x1 = (-b - Math.Sqrt(delta)) - (2 * a);
                x2 = (-b + Math.Sqrt(delta)) - (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine("X1 = " +x1);
                Console.WriteLine("X2 = " +x2);

            }

            Console.ReadKey();
        }
    }
}
