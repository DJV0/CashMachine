using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    class Storage
    {
        private static List<Product> products;
        private static List<Product> productsList;
        private static List<(Product, int, float)> sales;

        #region Property
        public static List<Product> Products
        {
            get
            {
                return products;
            }
        }
        public static List<Product> ProductsList
        {
            get
            {
                return productsList;
            }
        }

        public static List<(Product, int, float)> Sales
        {
            get
            {
                return sales;
            }
        }

        public static List<float> ReceiptList { get; set; }
        #endregion

        #region Ctor
        static Storage()
        {
            products = new List<Product>()
            {
                new Product{ Title = "Хлеб", Cost = 14.5f},
                new Product{ Title = "Сода", Cost = 9.25f},
                new Product{ Title = "Масло", Cost = 17.30f}
            };

            productsList = new List<Product>();
            sales = new List<(Product, int, float)>();
            ReceiptList = new List<float>();

            GenerateProductsList();
            GenerateSales();
        }
        #endregion

        #region Method
        public static void AddProduct(Product newProduct)
        {
            if (newProduct == null)
            {
                return;
            }
            if (products.Exists(p => p.Title == newProduct.Title))
            {
                var index = products.FindIndex(p => p.Title.Equals(newProduct.Title));
                products[index] = newProduct;
            }
            else
            {
                products.Add(newProduct);
            }

            GenerateProductsList();
        }

        public static void AddSale(Product product, int number, float cost)
        {
            var sale = (product, number, cost);
            if (product == null || sales.Contains(sale) || productsList.Contains(product) == false)
            {
                return;
            }
            sales.Add(sale);
        }

        private static void GenerateProductsList()
        {
            List<Product> generatedList = new List<Product>();
            foreach (Product product in products)
            {
                foreach (Product item in products)
                {
                    generatedList.Add(new Product 
                    { 
                        Title = $"{product.Title} {item.Title}", Cost = product.Cost + item.Cost 
                    });
                }
            }
            productsList = generatedList;
        }

        private static void GenerateSales()
        {
            Random rnd = new Random();
            float salePersent1 = 0.05f, salePersent2 = 0.1f;
            int lBound1 = 2, rBound1 = 6, lBound2 = 8, rBound2 = 13;
            ArrayList rndList = new ArrayList
            {
                rnd.Next(0, productsList.Count),
                rnd.Next(0, productsList.Count),
                rnd.Next(0, productsList.Count)
            };

            foreach (Product product in productsList)
            {
                product.AddSaleRandom(lBound1, rBound1, salePersent1);
            }
            foreach (var item in rndList)
            {
                productsList[(int)item].AddSaleRandom(lBound2, rBound2, salePersent2);
            }
        }
        #endregion

    }
}
