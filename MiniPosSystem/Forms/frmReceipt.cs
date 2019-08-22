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
            lblTotal.Text = "Total: " + order.Price.ToString();
            lblTime.Text = DateTime.Now.TimeOfDay.ToString();
            lblServer.Text = "Server: " + order.Server.FirstName;
            lblDate.Text = DateTime.Now.Date.ToString();

            if(order.PaymentInfo.NameOnCard != null)
            {
                PopulateCardInfo();
            }
            else
            {
                PopulateCashInfo();
            }
        }

        private void PopulateCashInfo()
        {
            lblCardNameCash.Text = order.PaymentInfo.CashTendered.ToString();
            lblChangeCard.Text = (order.PaymentInfo.CashTendered - order.Price).ToString();
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
