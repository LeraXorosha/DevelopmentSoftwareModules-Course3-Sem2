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
	public partial class MaterialsControl : UserControl
	{
		public event EventHandler<int> ProductsButtonClicked;

		private readonly Material _material;
		public MaterialsControl(Material material)
		{
			InitializeComponent();
			_material = material;

			tbIdMaterial.DataBindings.Add("Text", _material, "Id");
			tbNameMaterial.DataBindings.Add("Text", _material, "Name");
		}

		private void btnProductsMaterial_Click(object sender, EventArgs e)
		{
			int materialId = _material.Id;
			ProductsButtonClicked?.Invoke(this, materialId);
		}
	}
}
