using System;

namespace Baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp;
            bool check = false;
            double A;

            Console.Write("Nhap tham so A:");
            tmp = Console.ReadLine();
            check = double.TryParse(tmp, out A);

            while(check == false)
            {
                Console.Write("Tham so A khong hop le vui long nhap lai: ");
                tmp = Console.ReadLine();
                check = double.TryParse(tmp, out A);
            }

            check = false;
            double B;

            Console.Write("Nhap tham so B:");
            tmp = Console.ReadLine();
            check = double.TryParse(tmp, out B);

            while (check == false)
            {
                Console.Write("Tham so B khong hop le vui long nhap lai: ");
                tmp = Console.ReadLine();
                check = double.TryParse(tmp, out B);
            }


            if (A == 0)
            {
                if (B == 0)
                {
                    Console.Write("Phuong trinh co vo so nghiem");
                }
                else Console.Write("Phuong trinh vo nghiem");
            }
            else
            {
                double x = -B / A;
                Console.Write("Phuong trinh co nghiem x= " + x.ToString());
            }

           
        }
    }
}
