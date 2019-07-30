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
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(21, 69);
            this.cboServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(92, 21);
            this.cboServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server:";
            // 
            // btnDesserts
            // 
            this.btnDesserts.Location = new System.Drawing.Point(159, 177);
            this.btnDesserts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDesserts.Name = "btnDesserts";
            this.btnDesserts.Size = new System.Drawing.Size(69, 45);
            this.btnDesserts.TabIndex = 5;
            this.btnDesserts.Text = "Desserts";
            this.btnDesserts.UseVisualStyleBackColor = true;
            this.btnDesserts.Click += new System.EventHandler(this.BtnDesserts_Click);
            // 
            // btnEntrees
            // 
            this.btnEntrees.Location = new System.Drawing.Point(159, 109);
            this.btnEntrees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrees.Name = "btnEntrees";
            this.btnEntrees.Size = new System.Drawing.Size(69, 45);
            this.btnEntrees.TabIndex = 6;
            this.btnEntrees.Text = "Entrees";
            this.btnEntrees.UseVisualStyleBackColor = true;
            this.btnEntrees.Click += new System.EventHandler(this.BtnEntrees_Click);
            // 
            // btnBeverages
            // 
            this.btnBeverages.Location = new System.Drawing.Point(159, 41);
            this.btnBeverages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(69, 45);
            this.btnBeverages.TabIndex = 7;
            this.btnBeverages.Text = "Beverages";
            this.btnBeverages.UseVisualStyleBackColor = true;
            this.btnBeverages.Click += new System.EventHandler(this.BtnBeverages_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(274, 41);
            this.lstProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(157, 186);
            this.lstProducts.TabIndex = 8;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(274, 367);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(69, 45);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(11, 252);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(104, 160);
            this.lstOrder.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(274, 325);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 476);
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
            this.Name = "frmOrder";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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

