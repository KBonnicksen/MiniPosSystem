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


        /// <summary>
        /// Adds current order to the database if all input is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (radCard.Checked && IsValidCardInfo(txtCardNumber))
            {
                AddNewCard();
                FinalizePayment();
            }
            if (radCash.Checked && IsValidCashInput(txtCashGiven))
            {
                AddCashPayment(txtCashGiven.Text.Replace("$", string.Empty));
                FinalizePayment();
            }               
        }


        /// <summary>
        /// Adds the current order to the database and 
        /// displays the corresponding receipt to the user
        /// </summary>
        private void FinalizePayment()
        {
            TransactionsDB.AddTransaction(order);
            ShowReceipt();
            ActiveForm.Close();
        }


        /// <summary>
        /// Adds current cash payment information to the database
        /// </summary>
        private void AddCashPayment(string input)
        {
            decimal cashGiven = (Convert.ToDecimal(input));
            PaymentInfo cashPayment = new PaymentInfo()
            {
                CardNumber = 0,
                CashTendered = cashGiven
            };
            order.PaymentInfo = cashPayment;
            txtChange.Text = $"{ cashGiven - order.Price }";
        }


        /// <summary>
        /// Displays form consisting of the current order's information
        /// </summary>
        private void ShowReceipt()
        {
            Form receipt = new frmReceipt(order);
            receipt.ShowDialog();
        }


        /// <summary>
        /// Returns true if valid card information is supplied
        /// </summary>
        /// <returns></returns>
        private Boolean IsValidCardInfo(TextBox cardNumber)
        {
            string cardNumString = cardNumber.Text.Replace("-", string.Empty);
            try
            {
                // if not 16 digits
                if (cardNumString.Trim().Length < 16 ||
                    cardNumString.Trim().Length > 16)
                {
                    DisplayErrorMessage("Please enter valid card information ( ex. 5336-4349-6250-1234 )");
                    return false;
                }
                // if every entry is not completed
                if ( string.IsNullOrWhiteSpace(cardNumber.Text) ||
                     string.IsNullOrWhiteSpace(txtCardHolder.Text) ||
                    cboCardType.SelectedItem == null)
                {
                    DisplayErrorMessage("Please complete every entry");
                    return false;
                }
                // if card number input is not a number
                ulong value;
                if (!ulong.TryParse(cardNumString, out value))
                {
                    DisplayErrorMessage("Please enter a valid card number");
                    return false;
                }
            }
            catch (FormatException)
            {
                DisplayErrorMessage("Please enter valid information");
                return false;
            }
            return true;
        }


        /// <summary>
        /// Displays appropriate error message to user
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        private void DisplayErrorMessage(string errorMessage)
        {
            btnSubmit.Enabled = false;
            MessageBox.Show(errorMessage);
            btnSubmit.Enabled = true;
        }


        /// <summary>
        /// Returns false if no input is given or numbers are not 
        /// present. Enables/disables button accordingly for visual
        /// purposes.
        /// </summary>
        /// <returns>False if not valid numbers</returns>
        private Boolean IsValidCashInput(TextBox input)
        {
            string cashInput = txtCashGiven.Text.Replace("$", string.Empty);
            try
            {
                if (string.IsNullOrWhiteSpace(cashInput))
                {
                    DisplayErrorMessage("Please enter a cash amount");
                    return false;
                }
                if (Convert.ToDecimal(cashInput) < order.Price)
                {
                    DisplayErrorMessage("Please pay the bill in its entirety!");
                    return false;
                }
            }
            catch (FormatException)
            {
                DisplayErrorMessage("Please enter numbers in decimal format (ex. 8, 8.00, 8.50)");
                return false;
            }
            return true;
        }


        /// <summary>
        /// Adds current card payment to database
        /// </summary>
        private void AddNewCard()
        {
            PaymentInfo card = new PaymentInfo()
            {
                CardNumber = Convert.ToUInt64(txtCardNumber.Text.Replace("-", string.Empty)),
                NameOnCard = txtCardHolder.Text,
                CardType = cboCardType.SelectedItem.ToString()
            };
            PaymentInfoDB.AddPayment(card);
            order.PaymentInfo = card;
        }


    }
}
