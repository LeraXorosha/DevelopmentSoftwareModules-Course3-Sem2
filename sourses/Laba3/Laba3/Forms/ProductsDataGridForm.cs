using Laba3.Services.Implementations;
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
using Laba3.Services.Interfaces;
using Laba3.Database.Entity;

namespace Laba3
{
	internal partial class ProductsDataGridForm : Form
	{
		private readonly IDbWorker _dbWorker;
		public ProductsDataGridForm(IDbWorker dbWorker)
		{
			InitializeComponent();
			_dbWorker = dbWorker;
		}

		private void btnSaveProducts_Click(object sender, EventArgs e)
		{
			_dbWorker.SaveChanges();
			MessageBox.Show("Сохранено");
		}

		private void ProductsDataGridForm_Load(object sender, EventArgs e)
		{
			//dataGridProducts.DataSource = _dbWorker.Products;

			var productsQuery = from p in _dbWorker.Products 
								join Material in _dbWorker.Materials on p.MaterialId equals Material.Id
								select new
								{
									p.Id,
									p.Name,
									p.Price,
									MaterialName = Material.Name
								};
								
			dataGridProducts.DataSource = productsQuery.ToList();
			dataGridProducts.Refresh();

		}
	}
}