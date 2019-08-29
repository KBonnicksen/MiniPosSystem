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
            this.btnAddToOrder.Location = new System.Drawing.Point(28, 352);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(160, 53);
            this.btnAddToOrder.TabIndex = 1;
            this.btnAddToOrder.Text = "Proceed To Payment";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.BtnAddToOrder_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 16;
            this.lstProducts.Location = new System.Drawing.Point(28, 169);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(159, 116);
            this.lstProducts.TabIndex = 2;
            this.lstProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstProducts_MouseDoubleClick);
            // 
            // lstAddToOrder
            // 
            this.lstAddToOrder.FormattingEnabled = true;
            this.lstAddToOrder.ItemHeight = 16;
            this.lstAddToOrder.Location = new System.Drawing.Point(264, 169);
            this.lstAddToOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAddToOrder.Name = "lstAddToOrder";
            this.lstAddToOrder.Size = new System.Drawing.Size(159, 116);
            this.lstAddToOrder.TabIndex = 3;
            this.lstAddToOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstAddToOrder_MouseDoubleClick);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(28, 46);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 17);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "label1";
            // 
            // btnBeverages
            // 
            this.btnBeverages.Location = new System.Drawing.Point(28, 76);
            this.btnBeverages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(100, 28);
            this.btnBeverages.TabIndex = 5;
            this.btnBeverages.Text = "Beverages";
            this.btnBeverages.UseVisualStyleBackColor = true;
            this.btnBeverages.Click += new System.EventHandler(this.BtnBeverages_Click);
            // 
            // btnEntrees
            // 
            this.btnEntrees.Location = new System.Drawing.Point(167, 76);
            this.btnEntrees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrees.Name = "btnEntrees";
            this.btnEntrees.Size = new System.Drawing.Size(100, 28);
            this.btnEntrees.TabIndex = 6;
            this.btnEntrees.Text = "Entrees";
            this.btnEntrees.UseVisualStyleBackColor = true;
            this.btnEntrees.Click += new System.EventHandler(this.BtnEntrees_Click);
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(305, 76);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(100, 28);
            this.btnDesserts.TabIndex = 7;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.BtnDesserts_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(305, 46);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total: ";
            // 
            // lblAddMe
            // 
            this.lblAddMe.AutoSize = true;
            this.lblAddMe.Location = new System.Drawing.Point(28, 145);
            this.lblAddMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddMe.Name = "lblAddMe";
            this.lblAddMe.Size = new System.Drawing.Size(59, 17);
            this.lblAddMe.TabIndex = 9;
            this.lblAddMe.Text = "Add Me!";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(264, 144);
            this.lblCurrentOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(96, 17);
            this.lblCurrentOrder.TabIndex = 10;
            this.lblCurrentOrder.Text = "Current Order";
            // 
            // frmUpsell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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