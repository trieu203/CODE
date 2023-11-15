using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap diem mon Toan:");
            double diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Toan cua ban la : " + diemToan);

            Console.Write("Nhap diem mon Li:");
            double diemLi = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Li cua ban la : " + diemLi);

            Console.Write("Nhap diem mon Hoa:");
            double diemHoa = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem Toan cua ban la : " + diemHoa);

            double diemTB = (diemToan + diemLi + diemHoa) / 3;
            Console.WriteLine("Diem trung binh cua ban la : " + diemTB);

            if (diemTB >= 8)
            {
                Console.WriteLine("Ban dat hoc sinh Gioi");
            }
            else if (diemTB >= 6.5 && diemTB <= 7.9)
            {
                Console.WriteLine("Ban dat hoc sinh Kha");
            }
            else if ( diemTB >= 5 && diemTB < 6.5)
            {
                Console.WriteLine("Ban dat hoc sinh Trung Binh");
            }
            else {
                Console.WriteLine("Ban dat hoc sinh Yeu");
            }



            Console.ReadKey();
        }
    }
}
