using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Classes
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public string image { get; set; }
        private string Aisle;

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            price = 0;
            image = "";
            Aisle = "";

        }
        public string GetAisle()
        {
            return $"{Manufacturer[0].ToString().ToUpper()}{price}";//first letter of Manufacturer and price 



        }
        public override string ToString() //string representation for the toy
        {
            return $"{ Manufacturer} -{ Name}";


        }
    }
    }

