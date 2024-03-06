using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQ
{
    class List
    {
        List<Car> cars = Car.Cars;
        List<Truck> trucks = Truck.Trucks;
        public List() { }

        public void GetCarsByPriceBetween100and250()
        {
            var listCarPriceBetween100and250 = from car in cars
                                               where car.Price > 100000 && car.Price < 250000
                                               select car;
            Console.WriteLine("Danh sach Cars trong khoang gia 100.000 - 250.000\n");
            Console.WriteLine(" |   Id   |          Ten xe          |     Gia     | ");
            foreach (var item in listCarPriceBetween100and250)
            {
                Console.WriteLine("{0,7} {1,23} {2,15}", item.Id, item.Name, item.Price);
            }
        }
        public void GetCarsByYearUp1990()
        {
            var listCarUp1990 = from car in cars
                                where car.Year > 1990
                                select car;
            Console.WriteLine("Danh sach Cars co nam san xuat lon hon 1990\n");
            Console.WriteLine(" |   Id   |          Ten xe          |     Nam     | ");
            foreach (var item in listCarUp1990)
            {
                Console.WriteLine("{0,7} {1,23} {2,15}", item.Id, item.Name, item.Year);
            }
        }
        public void GetGroupCarsAndTotalPrice()
        {
            var groupCars = from car in cars
                              group car by car.Firm into firmGroup
                              select new
                              {
                                  Firm = firmGroup.Key,
                                  TotalPrice = firmGroup.Sum(c => c.Price)
                              };
            Console.WriteLine("Danh sach hang san xuat va tong gia tri theo nhom\n");
            Console.WriteLine("|   Hang xe   |          Tong gia tri          | ");
            foreach (var item in groupCars)
            {
               Console.WriteLine("{0,-26} {1,-25}", item.Firm, item.TotalPrice);
            }
        }
        public void GetTrucksByNewYear()
        {
            var listTruckByNewYear = from truck in trucks
                                     orderby truck.Year descending
                                     select truck;
            Console.WriteLine("Danh sach Trucks theo thu tu nam san xuat moi nhat\n");
            Console.WriteLine(" |   Id   |          Ten xe          |     Nam     | ");
            foreach (var item in listTruckByNewYear)
            {
                Console.WriteLine("{0,7} {1,23} {2,15}", item.Id, item.Name, item.Year);
            }
        }
        public void GetCompanysOfTruck()
        {
            var listCompanyOfTruck = from truck in trucks
                                     group truck by truck.Company into companyGroup
                                     select new
                                     {
                                         Company = companyGroup.Key,
                                         Cars = companyGroup.Select(c => c.Name)
                                     };
            Console.WriteLine("Danh sach ten cong ty chu quan cua Truck");
            foreach (var item in listCompanyOfTruck)
            {
                Console.WriteLine($"Cong ty chu quan: {item.Company}, gom cac xe: {string.Join(", ", item.Cars)}");
            }
        }
    }
}
