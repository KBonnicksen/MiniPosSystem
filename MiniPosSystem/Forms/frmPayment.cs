using MiniPosSystem.Forms;
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
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (radCard.Checked && IsValidCard(txtCardNumber))
                AddNewCard();

            else if(radCash.Checked && IsValidInput(txtCashGiven))
                AddCashPayment();

            TransactionsDB.AddTransaction(order);
            ShowReceipt();
            ActiveForm.Close();
        }

        private void AddCashPayment()
        {
            decimal cashGiven = (Convert.ToDecimal(txtCashGiven.Text));
            PaymentInfo cashPayment = new PaymentInfo()
            {
                CardNumber = 0,
                CashTendered = cashGiven
            };
            order.PaymentInfo = cashPayment;
            txtChange.Text = $"{ cashGiven - order.Price }";
        }

        private void ShowReceipt()
        {
            Form receipt = new frmReceipt(order);
            receipt.ShowDialog();
        }


        /// <summary>
        /// Returns true if valid information is given
        /// </summary>
        /// <returns></returns>
        private Boolean IsValidCard(TextBox input)
        {
            try
            {
                if ( string.IsNullOrWhiteSpace(input.Text) ||
                     string.IsNullOrWhiteSpace(input.Text) ||
                    cboCardType.SelectedItem == null)
                {
                    btnSubmit.Enabled = false;
                    MessageBox.Show("Please fill out every entry");
                    return false;
                }
            }
            catch (FormatException)
            {
                //MessageBox.Show("Please enter valid information");
                return false;
            }

            btnSubmit.Enabled = true;
            return true;
        }


        /// <summary>
        /// Returns false if no input is given or numbers are not 
        /// present.
        /// </summary>
        /// <returns>False if not valid numbers</returns>
        private Boolean IsValidInput(TextBox input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input.Text))
                {
                    btnSubmit.Enabled = false;
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
            try
            {
                PaymentInfo card = new PaymentInfo()
                {
                    CardNumber = Convert.ToUInt64(txtCardNumber.Text),
                    NameOnCard = txtCardHolder.Text,
                    CardType = cboCardType.SelectedItem.ToString()
                };
                PaymentInfoDB.AddPayment(card);
                order.PaymentInfo = card;
            }
            catch (FormatException)
            {
                btnSubmit.Enabled = false;
                MessageBox.Show("Please enter valid information");
            }
        }
    }
}
