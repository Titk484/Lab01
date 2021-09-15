using System;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu (" + i.ToString() + "):");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int tong = 0;
            for(int i = 0; i < n; i++)
            {
                tong += mang[i];
            }
            Console.Write("Tong cua mang la:" + tong.ToString());
            Console.WriteLine("");

            int max = -999;
            for(int i = 0; i < n; i++)
            {
                if (max < mang[i]) max = mang[i];
            }
            Console.Write("Max:" + max.ToString());
            Console.WriteLine();

            int min = 999;
            for (int i = 0; i < n; i++)
            {
                if (min > mang[i]) min = mang[i];
            }
            Console.Write("Min:" + min.ToString());
            Console.WriteLine();

        }
        /* canh 2
            Console.Write("Nhap so luong phan tu N: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int tong = 0, max = -999, min = 999;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu " + (i+1) + ": ");
                A[i] = int.Parse(Console.ReadLine());
                tong += A[i];
                if (A[i] > max) max = A[i];
                if (A[i] < min) min = A[i];
            }
            Console.WriteLine("Tong phan tu cua mang la: " + tong.ToString());
            Console.WriteLine("Phan tu lon nhat cua mang la: " + max.ToString());
            Console.WriteLine("Phan tu nho nhat cua mang la: " + min.ToString());
        */
    }
}
