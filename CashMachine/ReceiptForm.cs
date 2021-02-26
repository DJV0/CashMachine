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
    public partial class ReceiptForm : Form
    {
        Receipt receipt;

        private bool isCheckedTotalSale = false;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (isCheckedTotalSale)
            {
                Storage.ReceiptList.Add(receipt.Total - receipt.Total * Receipt.TotalSale);
            }
            else
            {
                Storage.ReceiptList.Add(receipt.Total);
            }
            this.Close();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            receipt.AddProductToReceipt();
            ReceiptListView.Items.Clear();
            foreach (var item in receipt.Products)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Product.Title.ToString();
                listViewItem.SubItems.Add((item.Number.ToString()));
                listViewItem.SubItems.Add((item.Price.ToString()));
                ReceiptListView.Items.Add(listViewItem);
            }

            TotalLabel.Text = receipt.Total.ToString();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            receipt = new Receipt();
        }

        private void TotalSaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isCheckedTotalSale)
            {
                TotalLabel.Text = receipt.Total.ToString();
                isCheckedTotalSale = false;
            }
            else
            {
                TotalLabel.Text = (receipt.Total - receipt.Total * Receipt.TotalSale).ToString();
                isCheckedTotalSale = true;
            }
        }
    }
}
