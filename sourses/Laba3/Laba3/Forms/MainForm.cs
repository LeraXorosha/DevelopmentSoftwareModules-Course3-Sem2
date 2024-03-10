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
	}
}
