using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPosSystem.Forms
{
    public partial class frmReceipt : Form
    {
        private readonly Transactions order;

        public frmReceipt(Transactions tran)
        {
            InitializeComponent();
            order = tran;
        }

        private void PopulateReceipt()
        {
            lblTotal.Text = "Total: $" + order.Price.ToString();
            lblServer.Text = "Server: " + order.Server.FirstName;
            PopulateDateInfo();
            PopulateOrderInfo();

            if (order.PaymentInfo.NameOnCard != null)
            {
                PopulateCardInfo();
            }
            else
            {
                PopulateCashInfo();
            }
        }

        private void PopulateOrderInfo()
        {
            //Populate the listbox with the names of the products
            //they ordered along with their price
            throw new NotImplementedException();
        }

        private void PopulateDateInfo()
        {
            DateTime date = DateTime.Now;

            lblTime.Text = date.Hour + ":" + date.Minute;
            lblDate.Text = date.Date.ToString();
        }

        private void PopulateCashInfo()
        {
            lblCardNameCash.Text = "Cash: $" + order.PaymentInfo.CashTendered.ToString();
            lblChangeCard.Text = "Change: $" + (order.PaymentInfo.CashTendered - order.Price).ToString();
        }

        private void PopulateCardInfo()
        {
            lblCardNameCash.Text = order.PaymentInfo.NameOnCard;
            string lastFour = (order.PaymentInfo.CardNumber.ToString()).Substring(12);
            lblChangeCard.Text = order.PaymentInfo.CardType.ToString()
                + " #XXXXXXXXXXXXX" + lastFour;
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            PopulateReceipt();
        }
    }
}
