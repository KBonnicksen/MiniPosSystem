namespace MiniPosSystem
{
    partial class frmPayment
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
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.grpCardInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCardType = new System.Windows.Forms.ComboBox();
            this.txtCardHolder = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpCashPayment = new System.Windows.Forms.GroupBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtCashGiven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCardInfo.SuspendLayout();
            this.grpCashPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(26, 33);
            this.radCash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(49, 17);
            this.radCash.TabIndex = 0;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            this.radCash.Click += new System.EventHandler(this.RadCash_Click);
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Location = new System.Drawing.Point(104, 33);
            this.radCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(47, 17);
            this.radCard.TabIndex = 1;
            this.radCard.TabStop = true;
            this.radCard.Text = "Card";
            this.radCard.UseVisualStyleBackColor = true;
            this.radCard.Click += new System.EventHandler(this.RadCard_Click);
            // 
            // grpCardInfo
            // 
            this.grpCardInfo.Controls.Add(this.lblTotalCard);
            this.grpCardInfo.Controls.Add(this.label3);
            this.grpCardInfo.Controls.Add(this.cboCardType);
            this.grpCardInfo.Controls.Add(this.txtCardHolder);
            this.grpCardInfo.Controls.Add(this.txtCardNumber);
            this.grpCardInfo.Controls.Add(this.label1);
            this.grpCardInfo.Controls.Add(this.label2);
            this.grpCardInfo.Location = new System.Drawing.Point(26, 68);
            this.grpCardInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCardInfo.Name = "grpCardInfo";
            this.grpCardInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCardInfo.Size = new System.Drawing.Size(364, 196);
            this.grpCardInfo.TabIndex = 2;
            this.grpCardInfo.TabStop = false;
            this.grpCardInfo.Text = "Credit Card Information";
            // 
            // lblTotalCard
            // 
            this.lblTotalCard.AutoSize = true;
            this.lblTotalCard.Location = new System.Drawing.Point(16, 30);
            this.lblTotalCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCard.Name = "lblTotalCard";
            this.lblTotalCard.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCard.TabIndex = 6;
            this.lblTotalCard.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type:";
            // 
            // cboCardType
            // 
            this.cboCardType.FormattingEnabled = true;
            this.cboCardType.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express",
            "Discover"});
            this.cboCardType.Location = new System.Drawing.Point(96, 147);
            this.cboCardType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCardType.Name = "cboCardType";
            this.cboCardType.Size = new System.Drawing.Size(92, 21);
            this.cboCardType.TabIndex = 10;
            // 
            // txtCardHolder
            // 
            this.txtCardHolder.Location = new System.Drawing.Point(96, 65);
            this.txtCardHolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardHolder.Name = "txtCardHolder";
            this.txtCardHolder.Size = new System.Drawing.Size(158, 20);
            this.txtCardHolder.TabIndex = 9;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(96, 107);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(158, 20);
            this.txtCardNumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Card number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name on card:";
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.AutoSize = true;
            this.lblTotalCash.Location = new System.Drawing.Point(27, 47);
            this.lblTotalCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCash.TabIndex = 4;
            this.lblTotalCash.Text = "Total:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(164, 280);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 45);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Payment";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // grpCashPayment
            // 
            this.grpCashPayment.Controls.Add(this.txtChange);
            this.grpCashPayment.Controls.Add(this.txtCashGiven);
            this.grpCashPayment.Controls.Add(this.label5);
            this.grpCashPayment.Controls.Add(this.label4);
            this.grpCashPayment.Controls.Add(this.lblTotalCash);
            this.grpCashPayment.Location = new System.Drawing.Point(26, 68);
            this.grpCashPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCashPayment.Name = "grpCashPayment";
            this.grpCashPayment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCashPayment.Size = new System.Drawing.Size(364, 196);
            this.grpCashPayment.TabIndex = 6;
            this.grpCashPayment.TabStop = false;
            this.grpCashPayment.Text = "Cash Payment";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(96, 136);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(76, 20);
            this.txtChange.TabIndex = 8;
            // 
            // txtCashGiven
            // 
            this.txtCashGiven.Location = new System.Drawing.Point(96, 90);
            this.txtCashGiven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCashGiven.Name = "txtCashGiven";
            this.txtCashGiven.Size = new System.Drawing.Size(76, 20);
            this.txtCashGiven.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Change:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cash:";
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 350);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpCashPayment);
            this.Controls.Add(this.grpCardInfo);
            this.Controls.Add(this.radCard);
            this.Controls.Add(this.radCash);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.grpCardInfo.ResumeLayout(false);
            this.grpCardInfo.PerformLayout();
            this.grpCashPayment.ResumeLayout(false);
            this.grpCashPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCard;
        private System.Windows.Forms.GroupBox grpCardInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCardType;
        private System.Windows.Forms.TextBox txtCardHolder;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpCashPayment;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtCashGiven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCard;
    }
}