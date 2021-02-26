using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public partial class StorageForm : Form
    {
        DataGridView productListView;
        public StorageForm()
        {
            InitializeComponent();

            productListView = new DataGridView();
            productListView.Location = new Point(5, 5);
            productListView.Width = this.Width - 25;
            productListView.Height = this.Height - 100;
            productListView.BackgroundColor = Color.White;
            productListView.RowHeadersVisible = false;
            productListView.AllowUserToAddRows = false;
            productListView.AllowUserToDeleteRows = false;
            productListView.ReadOnly = true;
            productListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            productListView.Columns.Add("Product", "Товары");
            productListView.Columns.Add("Cost", "Цена");
            

            this.Controls.Add(productListView);
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            foreach (Product product in Storage.ProductsList)
            {
                productListView.Rows.Add(product.Title, product.Cost);
                var salesForProduct = Storage.Sales.FindAll(s => s.Item1.Equals(product));
                if (salesForProduct.Count==0)
                {
                    continue;
                }
                else
                {
                    if (salesForProduct.Count*2 > productListView.Columns.Count-2)
                    {
                        for (int i = 0; i < salesForProduct.Count*2 - (productListView.Columns.Count - 2); i++)
                        {
                            productListView.Columns.Add($"NumberForSale-{productListView.Columns.Count+1}", "Скидка, кол-во");
                            productListView.Columns.Add($"SaleCost-{productListView.Columns.Count + 1}", "Скидка, цена");
                        }
                    }
                    int colIndex = 2;
                    foreach ((Product, int, float) sale in salesForProduct)
                    {
                        //Console.WriteLine(productListView.Columns.Count);
                        productListView.Rows[productListView.Rows.Count-1].Cells[colIndex].Value = sale.Item2;
                        productListView.Rows[productListView.Rows.Count-1].Cells[colIndex+1].Value = sale.Item3;
                        colIndex += 2;
                    }
                }
            }
        }
    }
}
