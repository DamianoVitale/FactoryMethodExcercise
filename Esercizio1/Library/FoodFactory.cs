using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1.Library
{
    public static class FoodFactory
    {
        public static IFood Get(string type, string name, double price)
        {
            if(type == "vegetables") return new Vegetables(name,price);
            if(type == "fruit") return new Fruit(name, price );
            return new Meat(name, price);

        }
    }
}
