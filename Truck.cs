using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQ
{
    class Truck : Vehicle
    {
        private string company;

        public Truck() : base() { }
        public Truck(int id, string name, double price, int year, string company)
            : base(id, name, price, year)
        {
            this.company = company;
        }

        public string Company { get; set; }

        public static List<Truck> Trucks
        {
            get
            {
                return new List<Truck>
                {
                    new Truck { Id = 1, Name = "Ford F-250 Super Duty", Price = 420000, Year = 1988, Company = "Ford" },
                    new Truck { Id = 2, Name = "Toyota Hilux", Price = 235000, Year = 2022, Company = "Toyota" },
                    new Truck { Id = 3, Name = "Ford Transit", Price = 350000, Year = 2021, Company = "Ford" },
                    new Truck { Id = 4, Name = "Ford Maverick", Price = 300000, Year = 2024, Company = "Ford" },
                    new Truck { Id = 5, Name = "Nissan Titan", Price = 240000, Year = 1995, Company = "Nissan" },
                    new Truck { Id = 6, Name = "Ford Expedition EL", Price = 565000, Year = 2022, Company = "Ford" },
                    new Truck { Id = 7, Name = "Nissan Kicks", Price = 120000, Year = 1990, Company = "Nissan" },
                    new Truck { Id = 8, Name = "Nissan Cabstar", Price = 230000, Year = 2021, Company = "Nissan" },
                    new Truck { Id = 9, Name = "Toyota HiAce", Price = 100000, Year = 2021, Company = "Toyota" },
                    new Truck { Id = 10, Name = "Nissan Navara", Price = 135000, Year = 2022, Company = "Nissan" },
                    new Truck { Id = 11, Name = "Toyota Prius", Price = 150000, Year = 2022, Company = "Toyota" },
                    new Truck { Id = 12, Name = "Ford Fusion", Price = 162000, Year = 2022, Company = "Ford" },
                    new Truck { Id = 13, Name = "Ford Explorer Sport Trac", Price = 145000, Year = 1989, Company = "Ford" },
                    new Truck { Id = 14, Name = "Toyota Sequoia", Price = 405000, Year = 2023, Company = "Toyota" },
                    new Truck { Id = 15, Name = "Toyota Corolla", Price = 220000, Year = 2023, Company = "Toyota" }
                };
            }
        }
    }
}
