using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Database;
using WinFormsApp.Forms;

namespace WinFormsApp
{
	public partial class MainForm : Form
	{
		private readonly IServiceProvider _serviceProvider;
		public MainForm(IServiceProvider serviceProvider)
		{

			InitializeComponent();
			_serviceProvider = serviceProvider;
		}

		private void btnLogMain_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<LoginDialog>();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("Вы успешно вошли!");
			}
		}

		private void btnRegistr_Click(object sender, EventArgs e)
		{
			var dialog = _serviceProvider.GetRequiredService<RegisterDialog>();

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("Вы успешно зарегистрировались!");
			}
		}
	}
}
