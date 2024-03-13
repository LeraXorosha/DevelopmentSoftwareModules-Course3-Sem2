using Laba3.Database.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3.UserControls
{
	public partial class ProductsControl : UserControl
	{
		private readonly Product _product;
		public ProductsControl(Product product, List<Material> materials)
		{
			InitializeComponent();
			_product = product;

			cbMaterialProduct.DataSource = materials;
			cbMaterialProduct.DisplayMember = "Name";
			cbMaterialProduct.ValueMember = "Id";

			tbIdProduct.DataBindings.Add("Text", _product, "Id");
			tbNameProduct.DataBindings.Add("Text", _product, "Name");
			tbPriceProduct.DataBindings.Add("Text", _product, "Price");
			cbMaterialProduct.DataBindings.Add("SelectedItem", _product, "Material");
		}
	}
}
