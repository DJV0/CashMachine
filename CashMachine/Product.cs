using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Product
    {
        public string Title { get; set; }
        public float Cost { get; set; }

        public Product()
        {

        }
        public Product(string title, float cost)
        {
            Title = title;
            Cost = cost;
        }

        public override string ToString() => $"Title: {this.Title}, Cost: {this.Cost}";
    }
}
