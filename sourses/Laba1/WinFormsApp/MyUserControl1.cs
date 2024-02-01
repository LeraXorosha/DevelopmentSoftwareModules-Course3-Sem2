using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
	public partial class MyUserControl1 : UserControl
	{
		public string Password 
		{
			get => txtShowPassword.Text; // 
			set => txtShowPassword.Text = value; 
		}
		public string Label 
		{ 
			get => lblShowPassword.Text;
			set =>  lblShowPassword.Text = value; 
		}

		private bool _isShow = false;
		public MyUserControl1()
		{
			InitializeComponent();
			txtShowPassword.PasswordChar = '*';
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_isShow = !_isShow;
			
			if (_isShow)
			{
				txtShowPassword.PasswordChar ='\0';
			}
			else
			{
				txtShowPassword.PasswordChar = '*';
			}
		}
	}
}
