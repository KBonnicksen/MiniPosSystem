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

        private void PopulateStoreInfo()
        {
            throw new NotImplementedException();
        }

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            PopulateStoreInfo();
        }
    }
}
