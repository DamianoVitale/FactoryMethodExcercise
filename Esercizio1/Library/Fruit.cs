using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1.Library
{
    internal class Fruit : IFood
    {
        public string Type { get; }
        public string Name { get; }
        public double Price { get; }
        public DateTime ExpirationDate { get; }

        public Fruit(string name, double price)
        {
            Name = name;
            Price = price;
            ExpirationDate = DateTime.Now.Date.AddDays(3);
            Type = "Fruit";

        }
        public void DisplayInfo() =>

               Console.WriteLine($"the food {Name} is {Type} with expiry date {ExpirationDate.Date.ToString("dd/MM/yyyy")} and price: ${Price}");


        
    }
}
