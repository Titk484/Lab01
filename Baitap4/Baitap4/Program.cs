using System;

namespace Baitap4
{
    class Program
    {
        /* 1
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho, ten lot va ten. Xuat ra ho ten day du. ");
            Console.WriteLine();

            Console.Write("Nhap ho:");
            string ho = Console.ReadLine();

            Console.Write("Nhap ten lot:");
            string tenlot = Console.ReadLine();

            Console.Write("Nhap ten:");
            string ten = Console.ReadLine();

            Console.WriteLine("Ho va ten day du: {0} {1} {2}", ho, tenlot, ten);
            Console.ReadKey(true);
        }
        */
        /* 2
        public static void Main(string [] args)
        {
            Console.WriteLine("Nhap ho, ten lot va ten. Xuat ra tung phan. ");
            Console.WriteLine();

            Console.Write("Nhap ho ten:");
            string fullname = Console.ReadLine();

            string SPACE = " ";
            string[] parts = fullname.Split(new string[] { SPACE }, StringSplitOptions.None);

            // Ham Split(new kieu_du_lieu[] { ky tu n can tach } se tu dong tach ky tu n moi khi gap.
            // StringSplitOptions.None - gia tri tra ve co the bao gom ca mang chua cac phan tu co chua ky tu null.

            Console.WriteLine("Ho: {0}, ten lot: {1}, ten: {2}", parts[0], parts[1], parts[2]);
            Console.ReadKey(true);
        }
        */
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten khong theo chuan. Chinh lai theo chuan va xuat ra.");
            Console.WriteLine();

            Console.Write("Nhap ho ten (khong can theo chuan):");
            string fullname = Console.ReadLine();

            string SEPERATOR = " ";
            // Tach tu dua vao khoang trang, khong lay cac gia tri rong 
            string[] parts = fullname.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);
            // StringSplitOptions.RemoveEmptyEntries - tra ve gia tri khong bao gom mang chua cac phan tu co ky tu null.

            
            string ho = parts[0].Substring(0, 1).ToUpper() + //Chu dau tien viet hoa
                parts[0].Substring(1, parts[0].Length - 1).ToLower();   // Phan con lai viet thuong

            string tenlot = parts[1].Substring(0, 1).ToUpper() + 
                parts[1].Substring(1, parts[1].Length - 1).ToLower();   

            string ten = parts[2].Substring(0, 1).ToUpper() + 
                parts[2].Substring(1, parts[2].Length - 1).ToLower();   
            
            
            Console.WriteLine("Ten theo dung chuan la: {0} {1} {2}", ho, tenlot, ten);
            Console.ReadKey(true);

            /*
            cách 2:
            Console.Write("Ten theo dung chuan la: ");
            for(int i=0; i<parts.Length ;i++){
                parts[i] = parts[i].Substring(0, 1).ToUpper() + 
                parts[i].Substring(1, parts[i].Length - 1).ToLower();
                Console.Write(" " + parts[i]);
            }
            */
        }
    }
}
