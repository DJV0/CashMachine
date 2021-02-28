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
        
        public StorageForm()
        {
            InitializeComponent();
        }

        private void CloseFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            StorageListView.Items.Clear();
            foreach (Product product in Storage.ProductsList)
            {
                ListViewItem listViewItem = new ListViewItem(product.Title);
                listViewItem.SubItems.Add(product.Cost.ToString());
                if (product.SaleList.Count * 2 > StorageListView.Columns.Count - 2)
                {
                    for (int i = 0; i < product.SaleList.Count * 2 - (StorageListView.Columns.Count - 2); i++)
                    {
                        StorageListView.Columns.Add("Скидка, кол-во", 100, HorizontalAlignment.Center);
                        StorageListView.Columns.Add("Скидка, цена", 100, HorizontalAlignment.Center);
                    }
                }
                foreach (var sale in product.SaleList)
                {
                    listViewItem.SubItems.Add(sale.Number.ToString());
                    listViewItem.SubItems.Add(sale.Cost.ToString());
                }
                StorageListView.Items.Add(listViewItem);
            }
        }
    }
}
