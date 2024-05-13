using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    internal class FoodNotFoundException : Exception
    {
        public FoodEnum FoodType { get; } 

        public FoodNotFoundException(FoodEnum type)
        {
            this.FoodType = type;

        }
        public override string Message => $"Food [{FoodType}] not found";

    }
}
