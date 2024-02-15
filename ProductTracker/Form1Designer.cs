namespace ProductTracker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.InvetoryGridView = new System.Windows.Forms.DataGridView();
            this.AddProduct = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.SaveProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InvetoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(43, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(230, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // InvetoryGridView
            // 
            this.InvetoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvetoryGridView.BackgroundColor = System.Drawing.Color.Linen;
            this.InvetoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvetoryGridView.Location = new System.Drawing.Point(43, 181);
            this.InvetoryGridView.Name = "InvetoryGridView";
            this.InvetoryGridView.Size = new System.Drawing.Size(1330, 448);
            this.InvetoryGridView.TabIndex = 2;
            this.InvetoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvetoryGridView_CellContentClick);
            this.InvetoryGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InvetoryGridView_CellContentDoubleClick);
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(43, 133);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(230, 42);
            this.AddProduct.TabIndex = 3;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProduct.Location = new System.Drawing.Point(416, 133);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(230, 42);
            this.UpdateProduct.TabIndex = 4;
            this.UpdateProduct.Text = "Update Product";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(763, 105);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(230, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(1143, 107);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(230, 20);
            this.quantityTextBox.TabIndex = 7;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(39, 78);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(185, 26);
            this.Name.TabIndex = 8;
            this.Name.Text = "Enter Product Name:";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(758, 78);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(182, 26);
            this.Price.TabIndex = 9;
            this.Price.Text = "Enter Product Price:";
            this.Price.Click += new System.EventHandler(this.label3_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(1138, 76);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(207, 26);
            this.Quantity.TabIndex = 10;
            this.Quantity.Text = "Enter Product Quantity:";
            // 
            // SaveProduct
            // 
            this.SaveProduct.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProduct.Location = new System.Drawing.Point(1143, 133);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(230, 42);
            this.SaveProduct.TabIndex = 11;
            this.SaveProduct.Text = "Save Product";
            this.SaveProduct.UseVisualStyleBackColor = true;
            this.SaveProduct.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(763, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete Selected Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1420, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveProduct);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.UpdateProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.InvetoryGridView);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvetoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView InvetoryGridView;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button SaveProduct;
        private System.Windows.Forms.Button button1;
    }
}
