using GUI.DTOs;
using GUI.Forms;
using GUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class ProductsForm : Form
    {
        private readonly ApiService _apiService;
        private List<ProductDto> _products;
        public ProductsForm()
        {
            InitializeComponent();
            _apiService = new ApiService();

            dgv.ReadOnly = true;

            btnAddProduct.Click += btnAddProduct_Click;
            btnEditProduct.Click += btnEditProduct_Click;
            btnDelete.Click += btnDeleteProduct_Click;

            this.Load += async (s, e) => await ReadProducts();
        }

        private async Task ReadProducts()
        {
            _products = await _apiService.GetProductsAsync();
            if (_products == null) return;

            dgv.DataSource = null; 
            dgv.DataSource = _products;
        }

        private async void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductEditForm(); 
            if (form.ShowDialog() == DialogResult.OK)
            {
                await _apiService.AddProductAsync(form.Product);
                await ReadProducts();
            }
        }

        private async void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow?.DataBoundItem is ProductDto selectedProduct)
            {
                var form = new ProductEditForm(selectedProduct); 
                if (form.ShowDialog() == DialogResult.OK)
                {
                    await _apiService.UpdateProductAsync(form.Product);
                    await ReadProducts();
                }
            }
            else
            {
                MessageBox.Show("Select a product first!");
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow?.DataBoundItem is ProductDto selectedProduct)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete {selectedProduct.ProductName}?",
                                              "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    await _apiService.DeleteProductAsync(selectedProduct.ProductId);
                    await ReadProducts();
                }
            }
            else
            {
                MessageBox.Show("Select a product first!");
            }
        }

    }
}
