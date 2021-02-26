using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class ReceiptItem
    {
        private Product product;
        private int productNumber;
        private float price;
        public Product Product { get => product; set { product = value; } }
        public int Number 
        { 
            get => productNumber;
            set
            {
                if (value > 0)
                {
                    var sales = Storage.Sales.FindAll(sale => sale.Item1.Equals(product));
                    if(sales != null)
                    {
                        sales.Sort((s1, s2) => s1.Item2.CompareTo(s2.Item2));
                        foreach ((Product,int,float) sale in sales)
                        {
                            if(value >= sale.Item2)
                            {
                                price = sale.Item3;
                            }
                        }
                    }
                }
                productNumber = value;
            }
        }
        public float Price
        {
            get => price;
            set
            {
                if(value >= 0)
                {
                    price = value;
                }
            }
        }

        public ReceiptItem()
        {

        }
        public ReceiptItem(Product product, float price = 0, int number = 1)
        {
            this.product = product;
            productNumber = number;
            if(price == 0)
            {
                this.price = product.Cost;
            }
            else
            {
                this.price = price;
            }
        }

        public override string ToString() => $"Product: {this.Product}, Number: {this.Number}, Price: {this.Price}";
    }
}
