using Laba3.Database.Entity;
using Laba3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba3.UserControls;
namespace Laba3.Forms
{
	internal partial class ProductsCustomForm : Form
	{
		private int _selectedMaterialId;
		public int SelectedMaterialId { get => _selectedMaterialId; set => _selectedMaterialId = value; }


		private readonly IDbWorker _dbWorker;
		public ProductsCustomForm(IDbWorker dbWorker, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_dbWorker = dbWorker;
		}

		private void btnSaveProductsCust_Click(object sender, EventArgs e)
		{
			_dbWorker.SaveChanges();
        }
		private void LoadProducts()
		{
			IEnumerable<Product> filteredProducts;
			var materials = _dbWorker.Materials.ToList();

			if (_selectedMaterialId == 0)
				filteredProducts = _dbWorker.Products;
			else
				filteredProducts = _dbWorker.Products.Where(p => p.MaterialId == _selectedMaterialId);

			foreach (var product in filteredProducts)
			{
				var productView = new ProductsControl(product, materials);

				PanelProducts.Controls.Add(productView);
			}
		}
		private void ProductsCustomForm_Load(object sender, EventArgs e)
		{
			LoadProducts();
		}
	}
}
