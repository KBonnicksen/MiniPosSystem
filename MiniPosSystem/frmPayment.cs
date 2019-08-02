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
            if (radCard.Checked)
            {
                AddNewCard();
            }

            TransactionsDB.AddTransaction(order);
            MessageBox.Show("Thank you for dining with us!");
            ActiveForm.Close();
        }

        private void AddNewCard()
        {
            PaymentInfo card = new PaymentInfo(){ 
                CardNumber = Convert.ToUInt64(txtCardNumber.Text),
                NameOnCard = txtCardHolder.Text,
                CardType = cboCardType.SelectedItem.ToString()
            };

            PaymentInfoDB.AddPayment(card);
            order.CardId = card.CardId;
        }
    }
}
