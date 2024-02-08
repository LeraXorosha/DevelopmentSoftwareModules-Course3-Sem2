using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
	public partial class DataBaseForm : Form
	{
		private int counter = 0;
		private int counterAge = 0;
		public DataBaseForm()
		{
			InitializeComponent();
		}


		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		public string CountData
		{
			get => txtCount.Text;
			set => txtCount.Text = value;
		}


		private void btnFormAdd_Click(object sender, EventArgs e)
		{
			counter++;
			var newControl = new DataControl
			{
				LabelId = $"{counter}"
			};

			newControl.DataChanged += (sender, e) =>
			{
				txtSumAge.Text = flowLayoutPanel1.Controls.OfType<DataControl>()
					.Sum(x => int.Parse(x.dataAge))
					.ToString();
			};

			flowLayoutPanel1.Controls.Add(newControl);

			//txtSumAge.Text = flowLayoutPanel1.Controls.OfType<DataControl>()
			//		.Sum(x => int.Parse(x.dataAge))
			//		.ToString();
		}


		private void txtCount_TextChanged(object sender, EventArgs e)
		{
			txtCount.Text = counter.ToString();
		}
	}
}
