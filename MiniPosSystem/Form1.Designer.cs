namespace MiniPosSystem
{
    partial class frmOrder
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.lblProductsList = new System.Windows.Forms.Label();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.btnEntrees = new System.Windows.Forms.Button();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1100, 434);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(81, 57);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product For Testing";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(1100, 376);
            this.cboProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(81, 24);
            this.cboProducts.TabIndex = 1;
            // 
            // lblProductsList
            // 
            this.lblProductsList.AutoSize = true;
            this.lblProductsList.Location = new System.Drawing.Point(1086, 334);
            this.lblProductsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductsList.Name = "lblProductsList";
            this.lblProductsList.Size = new System.Drawing.Size(106, 17);
            this.lblProductsList.TabIndex = 2;
            this.lblProductsList.Text = "List of Products";
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(28, 85);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(121, 24);
            this.cboServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server:";
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(212, 218);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(92, 55);
            this.btnDesserts.TabIndex = 5;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = true;
            // 
            // btnEntrees
            // 
            this.btnEntrees.Location = new System.Drawing.Point(212, 134);
            this.btnEntrees.Name = "btnEntrees";
            this.btnEntrees.Size = new System.Drawing.Size(92, 55);
            this.btnEntrees.TabIndex = 6;
            this.btnEntrees.Text = "Entrees";
            this.btnEntrees.UseVisualStyleBackColor = true;
            // 
            // btnBeverages
            // 
            this.btnBeverages.Location = new System.Drawing.Point(212, 50);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(92, 55);
            this.btnBeverages.TabIndex = 7;
            this.btnBeverages.Text = "Beverages";
            this.btnBeverages.UseVisualStyleBackColor = true;
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(366, 50);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(208, 228);
            this.lstProducts.TabIndex = 8;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(366, 452);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(92, 55);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 16;
            this.lstOrder.Location = new System.Drawing.Point(29, 311);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(138, 196);
            this.lstOrder.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(366, 400);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.btnEntrees);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboServer);
            this.Controls.Add(this.lblProductsList);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmOrder";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Label lblProductsList;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Button btnEntrees;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}

