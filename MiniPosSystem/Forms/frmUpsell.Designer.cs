namespace MiniPosSystem.Forms
{
    partial class frmUpsell
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
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstAddToOrder = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnEntrees = new System.Windows.Forms.Button();
            this.btnDesserts = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAddMe = new System.Windows.Forms.Label();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(21, 286);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(120, 43);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Proceed To Payment";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.BtnAddToOrder_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(21, 137);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(120, 95);
            this.lstProducts.TabIndex = 2;
            this.lstProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstProducts_MouseDoubleClick);
            // 
            // lstAddToOrder
            // 
            this.lstAddToOrder.FormattingEnabled = true;
            this.lstAddToOrder.Location = new System.Drawing.Point(198, 137);
            this.lstAddToOrder.Name = "lstAddToOrder";
            this.lstAddToOrder.Size = new System.Drawing.Size(120, 95);
            this.lstAddToOrder.TabIndex = 3;
            this.lstAddToOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstAddToOrder_MouseDoubleClick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(21, 37);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            // 
            // btnBeverages
            // 
            this.btnBeverages.Location = new System.Drawing.Point(21, 62);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(75, 23);
            this.btnBeverages.TabIndex = 5;
            this.btnBeverages.Text = "Beverages";
            this.btnBeverages.UseVisualStyleBackColor = true;
            this.btnBeverages.Click += new System.EventHandler(this.BtnBeverages_Click);
            // 
            // btnEntrees
            // 
            this.btnEntrees.Location = new System.Drawing.Point(125, 62);
            this.btnEntrees.Name = "btnEntrees";
            this.btnEntrees.Size = new System.Drawing.Size(75, 23);
            this.btnEntrees.TabIndex = 6;
            this.btnEntrees.Text = "Entrees";
            this.btnEntrees.UseVisualStyleBackColor = true;
            this.btnEntrees.Click += new System.EventHandler(this.BtnEntrees_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(229, 62);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(75, 23);
            this.btnDesserts.TabIndex = 7;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.BtnDesserts_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(229, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: ";
            // 
            // lblAddMe
            // 
            this.lblAddMe.AutoSize = true;
            this.lblAddMe.Location = new System.Drawing.Point(21, 118);
            this.lblAddMe.Name = "lblAddMe";
            this.lblAddMe.Size = new System.Drawing.Size(47, 13);
            this.lblAddMe.TabIndex = 9;
            this.lblAddMe.Text = "Add Me!";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(198, 117);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(70, 13);
            this.lblCurrentOrder.TabIndex = 10;
            this.lblCurrentOrder.Text = "Current Order";
            // 
            // frmUpsell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 366);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.lblAddMe);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnDesserts);
            this.Controls.Add(this.btnEntrees);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstAddToOrder);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnAddToOrder);
            this.Name = "frmUpsell";
            this.Text = "frmUpsell";
            this.Load += new System.EventHandler(this.FrmUpsell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListBox lstAddToOrder;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Button btnEntrees;
        private System.Windows.Forms.Button btnDesserts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAddMe;
        private System.Windows.Forms.Label lblCurrentOrder;
    }
}