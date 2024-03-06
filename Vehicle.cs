using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoDucManh_21115053120332_LinQ
{
    abstract class Vehicle
    {
        public int id;
        public string name;
        public double price;
        public int year;

        public Vehicle() { }

        protected Vehicle(int id, string name, double price, int year)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.year = year;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
    }
}
