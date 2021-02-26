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

        public List<Sale> SaleList { get; } = new List<Sale>();

        public Product()
        {

        }
        public Product(string title, float cost)
        {
            Title = title;
            Cost = cost;
        }

        public override string ToString() => $"Title: {this.Title}, Cost: {this.Cost}";
        public void AddSaleRandom(int lBound, int rBound, float salePersent)
        {
            Random rnd = new Random();
            if(rBound>lBound && salePersent>0 && salePersent < 1)
            {
                SaleList.Add(new Sale(rnd.Next(lBound, rBound), this.Cost - this.Cost * salePersent));
            }
        }
        public void AddSale(Sale sale)
        {
            SaleList.Add(sale);
        }
    }
}
