using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPosSystem
{
    public partial class frmPayment : Form
    {
        private Transactions order;
        public frmPayment(Transactions tran)
        {
            order = tran;
            InitializeComponent();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            string totalValue = "Total: $" + order.Price.ToString();
            lblTotalCash.Text = totalValue;
            lblTotalCard.Text = totalValue;
            grpCardInfo.Visible = false;
        }

        private void RadCash_Click(object sender, EventArgs e)
        {
            grpCardInfo.Visible = false;
            grpCashPayment.Visible = true;
        }

        private void RadCard_Click(object sender, EventArgs e)
        {
            grpCardInfo.Visible = true;
            grpCashPayment.Visible = false;
            btnSubmit.Enabled = false;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (radCard.Checked)
            {
                AddNewCard();
            }

            if(IsValidInput())
            {
                TransactionsDB.AddTransaction(order);
                MessageBox.Show("Thank you for dining with us!");
                ActiveForm.Close();
            }

            btnSubmit.Enabled = true;

        }


        /// <summary>
        /// Returns false if no input is given or numbers are not supplied.
        /// </summary>
        /// <returns>False if not valid numbers</returns>
        private Boolean IsValidInput()
        {
            try
            {
                if (txtCashGiven.Text == string.Empty)
                {
                    MessageBox.Show("Please enter a cash amount");
                    return false;
                }
                if (Convert.ToDecimal(txtCashGiven.Text) < order.Price)
                {
                    btnSubmit.Enabled = false;
                    MessageBox.Show("Please pay the bill in its entirety!");
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers in decimal format (ex. 8, 8.00, 8.50)");
                return false;
            }
            
            return true;
        }



        private void AddNewCard()
        {
            PaymentInfo card = new PaymentInfo(){ 
                CardNumber = Convert.ToUInt64(txtCardNumber.Text),
                NameOnCard = txtCardHolder.Text,
                CardType = cboCardType.SelectedItem.ToString()
            };

            PaymentInfoDB.AddPayment(card);
            order.PaymentInfo = card;
        }
    }
}
