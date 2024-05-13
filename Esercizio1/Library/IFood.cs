using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1.Library
{
    public interface IFood
    {
        public string Type { get; }
        public string Name { get; }
        public double Price { get; }
        public DateTime ExpirationDate { get; }
        
        void DisplayInfo();
    }
}
