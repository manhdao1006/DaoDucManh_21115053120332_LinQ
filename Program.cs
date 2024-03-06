using System;
using System.Linq;

namespace DaoDucManh_21115053120332_LinQ
{
    class Program
    {
        static List list;
        static void Menu()
        {
            try
            {
                Console.WriteLine("Nhap tu 1 - 5 de thuc hien cac chuc nang sau:");
                Console.WriteLine("1. Hien thi Cars co gia trong khoang 100.000 den 250.000");
                Console.WriteLine("2. Hien thi Cars co nam san xuat lon hon 1990");
                Console.WriteLine("3. Nhom Cars theo hang san xuat, tinh tong gia tri theo nhom");
                Console.WriteLine("4. Hien thi danh sach Truck theo thu tu nam san xuat moi nhat");
                Console.WriteLine("5. Hien thi ten cong ty chu quan cua Truck");
                int menu = 0;
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            list.GetCarsByPriceBetween100and250();
                            break;
                        }
                    case 2:
                        {
                            list.GetCarsByYearUp1990();
                            break;
                        }
                    case 3:
                        {
                            list.GetGroupCarsAndTotalPrice();
                            break;
                        }
                    case 4:
                        {
                            list.GetTrucksByNewYear();
                            break;
                        }
                    case 5:
                        {
                            list.GetCompanysOfTruck();
                            break;
                        }
                    default:
                        Console.WriteLine("Yeu cau nhap chuc nang cua menu tu 1 - 5");
                        Menu();
                        break;
                }
            }
            catch (Exception ex)
            {
                Menu();
            }
        }
        static void Main(string[] args)
        {
            list = new List();
            char c = 'y';
            while (c == 'y')
            {
                Menu();
                Console.WriteLine("\nNhap ky tu 'y' de tro ve menu hoac ky tu bat ky de thoat");
                c = Convert.ToChar(Console.ReadLine().ToLower());
            }
            Console.ReadKey();
        }
    }
}
