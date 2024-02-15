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

		private readonly IDbWorker _db;
		public LoginDialog()
		{
			InitializeComponent();
			_db = new IDbWorker(); 
		}

		private void myUserControl11_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
