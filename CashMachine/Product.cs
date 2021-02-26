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

        static Random rnd = new Random();

        public List<Sale> SaleList { get; } = new List<Sale>();

        public Product()
        {

        }
        public Product(string title, float cost)
        {
            Title = title;
            Cost = cost;
        }

        public override string ToString()
        {
            string product = $"Title: { this.Title}, Cost: { this.Cost},";
            foreach (var sale in this.SaleList)
            {
                product += sale.ToString() + " ";
            }
            return product;
        }
        public void AddSaleRandom(int lBound, int rBound, float salePersent)
        {
            if(rBound>lBound && salePersent>0 && salePersent < 1)
            {
                Sale newSale = new Sale(rnd.Next(lBound, rBound), this.Cost - this.Cost * salePersent);
                if (!SaleList.Contains(newSale))
                {
                    SaleList.Add(newSale);
                }
            }
        }
        public void AddSale(Sale sale)
        {
            SaleList.Add(sale);
        }
    }
}
