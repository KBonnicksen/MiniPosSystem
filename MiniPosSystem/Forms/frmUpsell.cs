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
    public partial class frmUpsell : Form
    {
        private Transactions existingOrder;

        public frmUpsell(Transactions oldOrder)
        {
            existingOrder = oldOrder;
            InitializeComponent();
        }

        private void FrmUpsell_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Any additional items?";
            PopulateCurrentOrderList(existingOrder.Products.ToList());
            List<Products> desserts = ProductDb.GetDesserts();
            PopulateProductsList(desserts);
        }

        /// <summary>
        /// Updates the total textbox on the form
        /// </summary>
        private void UpdateTotal()
        {
            lblTotal.Text = "$" + existingOrder.Price.ToString();
        }

        /// <summary>
        /// Populates comboBox on form with product names from the 
        /// current order
        /// </summary>
        private void PopulateCurrentOrderList(List<Products> products)
        {
            lstAddToOrder.DataSource = products;

            lstAddToOrder.DisplayMember = nameof(Products.Name);

            UpdateTotal();
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

        private void BtnEntrees_Click(object sender, EventArgs e)
        {
            List<Products> entrees = ProductDb.GetEntrees();
            PopulateProductsList(entrees);
        }

    

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            ShowPaymentForm();
        }

        /// <summary>
        /// Displays form consisting of the current order's information
        /// </summary>
        private void ShowPaymentForm()
        {
            Form paymentForm = new frmPayment(existingOrder);
            paymentForm.ShowDialog();
        }

        private void BtnBeverages_Click(object sender, EventArgs e)
        {
            List<Products> beverages = ProductDb.GetBeverages();
            PopulateProductsList(beverages);
        }

        private void BtnDesserts_Click_1(object sender, EventArgs e)
        {
            List<Products> desserts = ProductDb.GetDesserts();
            PopulateProductsList(desserts);
        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment(existingOrder);
            payment.Show();
        }

        private void LstProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                Products newItem = (Products)lstProducts.SelectedItem;
                existingOrder.Products.Add(newItem);
                PopulateCurrentOrderList(existingOrder.Products.ToList());
            }

        }

        private void LstAddToOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAddToOrder.SelectedIndex >= 0)
            {
                int current = lstAddToOrder.SelectedIndex;
                Products selectedProduct = lstAddToOrder.SelectedItem as Products;
                existingOrder.Products.Remove(selectedProduct);
                UpdateTotal();
                PopulateCurrentOrderList(existingOrder.Products.ToList());
            }
        }

        private void LstAddToOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            Products selectedItem = (Products)lstAddToOrder.SelectedItem;

            PopulateProductsList(selectedItem.AddOnItems);
        }
    }
}
