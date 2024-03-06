using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQ
{
    class Car : Vehicle
    {
        private string firm;

        public Car() : base() { }
        public Car(int id, string name, double price, int year, string firm)
            : base(id, name, price, year)
        {
            this.firm = firm;
        }

        public string Firm { get; set; }

        public static List<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { Id = 1, Name = "Toyota Camry", Price = 250000, Year = 1988, Firm = "Toyota" },
                    new Car { Id = 2, Name = "Honda Civic", Price = 235000, Year = 2022, Firm = "Honda" },
                    new Car { Id = 3, Name = "Ford Mustang", Price = 350000, Year = 2021, Firm = "Ford" },
                    new Car { Id = 4, Name = "Honda CR-V", Price = 300000, Year = 2024, Firm = "Honda" },
                    new Car { Id = 5, Name = "BMW i3", Price = 440000, Year = 1995, Firm = "BMW" },
                    new Car { Id = 6, Name = "BMW 3 Series", Price = 400000, Year = 2022, Firm = "BMW" },
                    new Car { Id = 7, Name = "BMW Z4", Price = 550000, Year = 1990, Firm = "BMW" },
                    new Car { Id = 8, Name = "Toyota 4Runner", Price = 136000, Year = 2021, Firm = "Toyota" },
                    new Car { Id = 9, Name = "Toyota RAV4", Price = 100000, Year = 2021, Firm = "Toyota" },
                    new Car { Id = 10, Name = "Ford EcoSport", Price = 235000, Year = 2022, Firm = "Ford" },
                    new Car { Id = 11, Name = "Toyota Prius", Price = 150000, Year = 2022, Firm = "Toyota" },
                    new Car { Id = 12, Name = "Ford Fusion", Price = 162000, Year = 2022, Firm = "Ford" },
                    new Car { Id = 13, Name = "Ford Ranger", Price = 150000, Year = 1989, Firm = "Ford" },
                    new Car { Id = 14, Name = "Ford Bronco", Price = 405000, Year = 2023, Firm = "Ford" },
                    new Car { Id = 15, Name = "Toyota Corolla", Price = 220000, Year = 2023, Firm = "Toyota" }
                };
            }
        }
    }
}
