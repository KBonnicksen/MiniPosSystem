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
    public partial class frmManageServers : Form
    {
        protected Servers _server;
        public frmManageServers(Servers server)
        {
            _server = server;
            InitializeComponent();
        }

        private void FrmManageServers_Load(object sender, EventArgs e)
        {
            txtFName.Text = _server.FirstName;
            txtLName.Text = _server.LastName;
        }

        private void BtnUpdateServ_Click(object sender, EventArgs e)
        {
            _server.FirstName = txtFName.Text;
            _server.LastName = txtLName.Text;
            if (ServerDB.UpdateServer(_server))
            {
                MessageBox.Show($"{_server.FirstName} {_server.LastName} has been updated");
            };
        }

        private void BtnDeleteServ_Click(object sender, EventArgs e)
        {
            if(ServerDB.DeleteServer(_server))
            {
                MessageBox.Show("Server has been successfully removed.");
            }
        }
    }
}
