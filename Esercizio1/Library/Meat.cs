using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1.Library
{
     class Meat : IFood
    {
        public string Type { get; }
        public string Name { get; }
        public double Price { get; }
        public DateTime ExpirationDate { get; }

        public Meat(string name, double price)
        {
            Name = name;
            Price = price;
            ExpirationDate = DateTime.Now.Date.AddDays(10);
            Type = "Meat";
            
        }
        public void DisplayInfo() =>
        
            Console.WriteLine($"the food {Name} is {Type} with expiry date {ExpirationDate.Date.ToString("dd/MM/yyyy")} and price: ${Price}");
        

       

    }
}
