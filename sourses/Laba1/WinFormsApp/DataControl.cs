using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp
{
	public partial class DataControl : UserControl
	{
		public string LabelId
		{
			get => lblID.Text;
			set => lblID.Text = value;
		}

		public string dataAge
		{
			get => txtAge.Text;
			set => txtAge.Text = value;
		}

		public string dataFamily
		{
			get => txtFamily.Text;
			set => txtFamily.Text = value;
		}
		public string dataName
		{
			get => txtName.Text;
			set => txtName.Text = value;
		}
		public string dataFather
		{
			get => txtFather.Text;
			set => txtFather.Text = value;
		}

		public event EventHandler DataChanged;
		public event EventHandler DataRemoved;


		public DataControl()
		{
			InitializeComponent();
		}


		private void btnEdit_Click(object sender, EventArgs e)
		{
			EditData editForm = new EditData()
			{
				Family = txtFamily.Text,
				Name = txtName.Text,
				Father = txtFather.Text,
				Age = txtAge.Text,
				saveID = lblID.Text

			};
			editForm.ShowDialog();

			if (editForm.DialogResult == DialogResult.OK)
			{
				dataAge = editForm.Age;
				dataFamily = editForm.Family;
				dataName = editForm.Name;
				dataFather = editForm.Father;

				DataChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Parent?.Controls.Remove(this);
			DataRemoved?.Invoke(this, EventArgs.Empty);
		}
	}
}
