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
        public frmOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateProductsList();

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
        private void PopulateProductsList()
        {
            List<Products> products = ProductDb.GetProducts();

            lstProducts.DataSource = products;

            lstProducts.DisplayMember = nameof(Products.Name);
        }

        /// <summary>
        /// Adds new product to database and repopulates product comboBox
        /// on form. Mainly for testing purposes as of now (7/26/2019)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Products newProduct = new Products()
            {
                Name = "Margarita Pizza",
                Price = 10.00m
            };

            ProductDb.AddProduct(newProduct);
            string successMessage = $"Added {newProduct.Id}: {newProduct.Name}: {newProduct.Price}";
            MessageBox.Show(successMessage);

            PopulateProductsList();
        }
    }
}
