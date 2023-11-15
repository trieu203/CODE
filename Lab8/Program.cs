using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Chon phep tinh ban muon thuc hien: ");
            Console.WriteLine("1.Thuc hien phep Cong");
            Console.WriteLine("2.Thuc hien phep Tru");
            Console.WriteLine("3.Thuc hien phep Nhan");
            Console.WriteLine("4.Thuc hien phep Chia");

            int chon = int.Parse(Console.ReadLine());

            int ketqua = 0;

            switch (chon)
            {
                case 1:
                    ketqua = a + b;
                    Console.WriteLine("{0} + {1} = {2} ", a , b , ketqua);
                    break;
                case 2:
                    ketqua = a - b;
                    Console.WriteLine("{0} - {1} = {2} ", a, b, ketqua);
                    break;
                case 3:
                    ketqua = a * b;
                    Console.WriteLine("{0} * {1} = {2} ", a, b, ketqua);
                    break;
                case 4:
                    ketqua = a / b;
                    Console.WriteLine("{0} / {1} = {2} ", a, b, ketqua);
                    break;
                default:
                    Console.WriteLine("Khong thuc hien duoc phep tinh");
                    break;
            }

            Console.ReadLine();
        }
    }
}
