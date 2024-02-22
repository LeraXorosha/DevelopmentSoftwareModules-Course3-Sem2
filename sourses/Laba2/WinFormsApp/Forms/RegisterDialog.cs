using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Services.Interfaces;

namespace WinFormsApp.Forms
{
	public partial class RegisterDialog : Form
	{
		private readonly IDbWorker _dbWorker;

		public RegisterDialog(IDbWorker dbWorker)
		{
			InitializeComponent();
			_dbWorker = dbWorker;
		}

		private void btnRegis_Click(object sender, EventArgs e)
		{
			var login = txtRegLog.Text;
			var password = txrRegPas.Text;
			var passwordAgain = txrRegPasAg.Text;

			if (password != passwordAgain)
			{
				MessageBox.Show("Пароли не совпадают!");
				return;
			}

			if (_dbWorker.IsUserAlreadyExists(login))
			{
				MessageBox.Show("Такой логин уже занят!");
				return;
			}

			_dbWorker.AddUser(login, password);

			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
