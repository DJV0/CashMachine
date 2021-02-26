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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StorageForm storageForm = new StorageForm();
            storageForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("----- Sales -----");
            foreach (var item in Storage.Sales.GroupBy(x => x.Item1))
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("****");
            }

            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            ReceiptListView.Items.Clear();
            foreach (var item in Storage.ReceiptList)
            {
                ListViewItem listViewItem = new ListViewItem(item.ToString());
                ReceiptListView.Items.Add(listViewItem);
            }
        }
    }
}
