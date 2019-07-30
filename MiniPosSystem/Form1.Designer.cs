namespace MiniPosSystem
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.lblProductsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(144, 167);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(196, 75);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product For Testing";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(144, 69);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(196, 21);
            this.cboProducts.TabIndex = 1;
            // 
            // lblProductsList
            // 
            this.lblProductsList.AutoSize = true;
            this.lblProductsList.Location = new System.Drawing.Point(47, 72);
            this.lblProductsList.Name = "lblProductsList";
            this.lblProductsList.Size = new System.Drawing.Size(80, 13);
            this.lblProductsList.TabIndex = 2;
            this.lblProductsList.Text = "List of Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProductsList);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Label lblProductsList;
    }
}

