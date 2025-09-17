using GUI.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class ProductEditForm : Form
    {
        public ProductDto Product { get; private set; }

        public ProductEditForm()
        {
            InitializeComponent();
            Product = new ProductDto();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }
        public ProductEditForm(ProductDto product) : this()
        {
            Product = product;
            txtName.Text = product.ProductName;
            txtPrice.Text = product.Price.ToString();
            txtDescription.Text = product.Description;
            txtStock.Text = product.StockQuantity.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product.ProductName = txtName.Text;
            Product.Price = double.Parse(txtPrice.Text);
            Product.Description = txtDescription.Text;
            Product.StockQuantity = int.Parse(txtStock.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
