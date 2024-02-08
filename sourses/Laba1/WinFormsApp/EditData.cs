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
	public partial class EditData : Form
	{
		public string Family
		{
			get => txtEditFamily.Text;
			set => txtEditFamily.Text = value;
		}
		public string Name
		{
			get => txtEditName.Text;
			set => txtEditName.Text = value;
		}
		public string Father
		{
			get => txtEditFather.Text;
			set => txtEditFather.Text = value;
		}
		public string Age
		{
			get => txtEditAge.Text;
			set => txtEditAge.Text = value;
		}
		public string saveID
		{
			get => txtEditId.Text;
			set => txtEditId.Text = value;
		}

		public EditData()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();

		}
	}
}
