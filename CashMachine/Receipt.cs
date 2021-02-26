using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Receipt
    {
        private float total;
        private static float totalSale;
        private List<ReceiptItem> products;

        #region Property
        public float Total { get => total; }

        public static float TotalSale
        {
            get
            {
                return totalSale;
            }
            set
            {
                if(value > 0)
                {
                    totalSale = value;
                }
            }
        }
        public List<ReceiptItem> Products{ get => products; }
        #endregion

        #region Ctor
        public Receipt()
        {
            total = 0;
            totalSale = 0.03f;
            products = new List<ReceiptItem>();
        }
        #endregion

        #region Method
        public void AddProductToReceipt()
        {
            Random rnd = new Random();
            Product newProduct = Storage.ProductsList[rnd.Next(0, Storage.ProductsList.Count)];
            if(products.Exists(item => item.Product.Equals(newProduct)))
            {
                int newProductIndex = products.FindIndex(item => item.Product.Equals(newProduct));
                products[newProductIndex].Number += 1;
            }
            else
            {
                ReceiptItem item = new ReceiptItem(newProduct);
                products.Add(item);
            }
            CalculateTotal();
            Console.WriteLine("-----------------");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }

        private void CalculateTotal()
        {
            total = 0;
            if (products.Count == 0)
            {
                total = 0;
            }
            foreach (ReceiptItem item in products)
            {
                total += item.Price * item.Number;
            }
        }
        #endregion
    }
}
