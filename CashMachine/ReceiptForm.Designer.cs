
namespace CashMachine
{
    partial class ReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ReceiptListView = new System.Windows.Forms.ListView();
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalSaleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(12, 12);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(170, 32);
            this.AddProductBtn.TabIndex = 0;
            this.AddProductBtn.Text = "Добавить товар";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(155, 406);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 32);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ReceiptListView
            // 
            this.ReceiptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product,
            this.number,
            this.price});
            this.ReceiptListView.HideSelection = false;
            this.ReceiptListView.Location = new System.Drawing.Point(12, 50);
            this.ReceiptListView.Name = "ReceiptListView";
            this.ReceiptListView.Size = new System.Drawing.Size(377, 287);
            this.ReceiptListView.TabIndex = 2;
            this.ReceiptListView.UseCompatibleStateImageBehavior = false;
            this.ReceiptListView.View = System.Windows.Forms.View.Details;
            // 
            // product
            // 
            this.product.Text = "Продукт";
            this.product.Width = 100;
            // 
            // number
            // 
            this.number.Text = "Количество";
            this.number.Width = 100;
            // 
            // price
            // 
            this.price.Text = "Цена";
            this.price.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Общая сумма:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(132, 361);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(16, 17);
            this.TotalLabel.TabIndex = 4;
            this.TotalLabel.Text = "0";
            // 
            // TotalSaleCheckBox
            // 
            this.TotalSaleCheckBox.AutoSize = true;
            this.TotalSaleCheckBox.Location = new System.Drawing.Point(284, 357);
            this.TotalSaleCheckBox.Name = "TotalSaleCheckBox";
            this.TotalSaleCheckBox.Size = new System.Drawing.Size(105, 21);
            this.TotalSaleCheckBox.TabIndex = 5;
            this.TotalSaleCheckBox.Text = "Скидка, 3%";
            this.TotalSaleCheckBox.UseVisualStyleBackColor = true;
            this.TotalSaleCheckBox.CheckedChanged += new System.EventHandler(this.TotalSaleCheckBox_CheckedChanged);
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.TotalSaleCheckBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiptListView);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Name = "ReceiptForm";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ListView ReceiptListView;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.CheckBox TotalSaleCheckBox;
    }
}