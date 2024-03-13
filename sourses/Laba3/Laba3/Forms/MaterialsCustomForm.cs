using Laba3.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
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
	internal partial class MaterialsCustomForm : Form
	{
		private readonly IDbWorker _dbWorker;
		private readonly IServiceProvider _serviceProvider;
		public MaterialsCustomForm(IDbWorker dbWorker, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			_dbWorker = dbWorker;
			_serviceProvider = serviceProvider;
		}

		private void btnSaveMaterialsCust_Click(object sender, EventArgs e)
		{
			_dbWorker.SaveChanges();
		}

		private void MaterialsCustomForm_Load(object sender, EventArgs e)
		{
			LoadMaterials();
		}

		private void LoadMaterials()
		{
			foreach (var material in _dbWorker.Materials)
			{
				var materialView = new MaterialsControl(material);

				materialView.ProductsButtonClicked += MaterialView_ProductsButtonClicked;
				
				PanelMaterial.Controls.Add(materialView);
			}
		}

		private void MaterialView_ProductsButtonClicked(object sender, int materialId)
		{
			var selectedMaterial = _dbWorker.Materials.FirstOrDefault(m => m.Id == materialId);
			if (selectedMaterial != null)
			{
				ProductsCustomForm customProductForm = _serviceProvider.GetRequiredService<ProductsCustomForm>();
				customProductForm.SelectedMaterialId = selectedMaterial.Id; // Передаем ID выбранного материала
				customProductForm.ShowDialog();
			}
		}
	}
}
