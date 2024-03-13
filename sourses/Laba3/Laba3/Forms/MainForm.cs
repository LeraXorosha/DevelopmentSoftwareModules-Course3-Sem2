using Laba3.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Laba3
{
	public partial class MainForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		public MainForm(IServiceProvider serviceProvider)
		{

			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void btnOpenMaterials_Click(object sender, EventArgs e)
		{
			MaterialsDataGridForm materialsGrid = _serviceProvider.GetRequiredService<MaterialsDataGridForm>();
			materialsGrid.Show();
		}

		private void btnOpenProducts_Click(object sender, EventArgs e)
		{
			ProductsDataGridForm productsGrid = _serviceProvider.GetRequiredService<ProductsDataGridForm>();
			productsGrid.Show();
		}

		private void btnOpenCustMaterials_Click(object sender, EventArgs e)
		{
			MaterialsCustomForm productsGrid = _serviceProvider.GetRequiredService<MaterialsCustomForm>();
			productsGrid.Show();
		}

		private void btnOpenCustProducts_Click(object sender, EventArgs e)
		{
			ProductsCustomForm productsGrid = _serviceProvider.GetRequiredService<ProductsCustomForm>();
			productsGrid.Show();
		}
	}
}
