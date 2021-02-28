
namespace CashMachine
{
    partial class StorageForm
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
            this.CloseFormBtn = new System.Windows.Forms.Button();
            this.StorageListView = new System.Windows.Forms.ListView();
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CloseFormBtn
            // 
            this.CloseFormBtn.Location = new System.Drawing.Point(363, 302);
            this.CloseFormBtn.Name = "CloseFormBtn";
            this.CloseFormBtn.Size = new System.Drawing.Size(92, 30);
            this.CloseFormBtn.TabIndex = 0;
            this.CloseFormBtn.Text = "ОК";
            this.CloseFormBtn.UseVisualStyleBackColor = true;
            this.CloseFormBtn.Click += new System.EventHandler(this.CloseFormBtn_Click);
            // 
            // StorageListView
            // 
            this.StorageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product,
            this.cost});
            this.StorageListView.HideSelection = false;
            this.StorageListView.Location = new System.Drawing.Point(12, 12);
            this.StorageListView.Name = "StorageListView";
            this.StorageListView.Size = new System.Drawing.Size(788, 271);
            this.StorageListView.TabIndex = 1;
            this.StorageListView.UseCompatibleStateImageBehavior = false;
            this.StorageListView.View = System.Windows.Forms.View.Details;
            // 
            // product
            // 
            this.product.Text = "Продукты";
            this.product.Width = 100;
            // 
            // cost
            // 
            this.cost.Text = "Цена";
            this.cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cost.Width = 80;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 344);
            this.Controls.Add(this.StorageListView);
            this.Controls.Add(this.CloseFormBtn);
            this.Name = "StorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseFormBtn;
        private System.Windows.Forms.ListView StorageListView;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader cost;
    }
}