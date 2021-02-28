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
                    if(product.SaleList != null)
                    {
                        product.SaleList.Sort((s1, s2) => s1.Number.CompareTo(s2.Number));
                        foreach (Sale sale in product.SaleList)
                        {
                            if(value >= sale.Number)
                            {
                                price = sale.Cost;
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
