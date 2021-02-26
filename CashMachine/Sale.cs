using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Sale
    {
        public int Number { get; set; }
        public float Cost { get; set; }

        public Sale()
        {

        }
        public Sale(int number, float cost)
        {
            Number = number;
            Cost = cost;
        }
    }
}
