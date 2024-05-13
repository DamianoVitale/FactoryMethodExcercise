using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1.Library
{
    internal class ShoppingCart
    {
        List<IFood> Foods = new List<IFood>();
        public void AddItem(IFood food) => Foods.Add(food);
        
        public void RemoveItem(IFood food) => Foods.Remove(food);
        
        public double CalculateTotal()
        {
            double total = 0;
            foreach (IFood food in Foods)
            {
                total = total + food.Price;
            }
            
            return Math.Round(total, 2);
        }
    }
}
