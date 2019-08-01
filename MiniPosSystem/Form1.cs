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
    public partial class frmOrder : Form
    {
        public Transactions order;
        public frmOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            order = new Transactions();
            PopulateServers();
        }

        /// <summary>
        /// Populates the server combo box with the first name of every server
        /// </summary>
        private void PopulateServers()
        {
            List<Servers> servers = ServerDB.GetServers();
            cboServer.DataSource = servers;
            cboServer.DisplayMember = nameof(Servers.FirstName);
        }

        /// <summary>
        /// Populates comboBox on form with product names from the 
        /// database
        /// </summary>
        private void PopulateProductsList(List<Products> products)
        {
            lstProducts.DataSource = products;

            lstProducts.DisplayMember = nameof(Products.Name);
        }

        private void BtnBeverages_Click(object sender, EventArgs e)
        {
            List<Products> beverages = ProductDb.GetBeverages();
            PopulateProductsList(beverages);

        }

        private void BtnEntrees_Click(object sender, EventArgs e)
        {
            List<Products> entrees = ProductDb.GetEntrees();
            PopulateProductsList(entrees);
        }

        private void BtnDesserts_Click(object sender, EventArgs e)
        {
            List<Products> desserts = ProductDb.GetDesserts();
            PopulateProductsList(desserts);
        }

        /// <summary>
        /// Sets the server for the transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servers s = cboServer.SelectedItem as Servers;
            order.ServerId = s.ServerId;
        }

        /// <summary>
        /// Adds an item to the order on double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstProducts.SelectedItem != null)
            {
                Products newItem = (Products)lstProducts.SelectedItem;
                order.Products.Add(newItem);
                lstOrder.Items.Add($"{newItem.Name} - ${newItem.Price}");
                UpdateTotal();
            }
        }

        /// <summary>
        /// Updates the total textbox on the form
        /// </summary>
        private void UpdateTotal()
        {
            txtTotal.Text = "$" + order.Price.ToString();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment(order);
            payment.Show();
        }
    }
}
