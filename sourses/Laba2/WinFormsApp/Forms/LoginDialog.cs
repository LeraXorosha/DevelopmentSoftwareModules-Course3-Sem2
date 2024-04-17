using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Database;
using WinFormsApp.Services.Interfaces;

namespace WinFormsApp.Forms
{
	public partial class LoginDialog : Form
	{

		private readonly IDbWorker _dbWorker;

		public LoginDialog(IDbWorker dbWorker)
		{
			InitializeComponent();
			_dbWorker = dbWorker;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var login = txrLogLog.Text;
			var password = txtLogPas.Text;

			var result = _dbWorker.Auntificate(login, password);

			switch (result)
			{
				case LoginErrors.Success:
					DialogResult = DialogResult.OK;	
					Close();
					return;
				case LoginErrors.LoginIncorrect:
					MessageBox.Show($"Ошибка {result}!!!");
					return;
				case LoginErrors.PasswordIncorrect:
					MessageBox.Show($"Ошибка {result}!!!");
					return;
				default:
					MessageBox.Show($"Ошибка!!!");
					return;
			}
			
		}
	}
}
