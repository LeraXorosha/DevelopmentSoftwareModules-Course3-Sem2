using Laba3.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3
{
	public partial class MaterialsDataGridForm : Form
	{
		private readonly IDbWorker _dbWorker;

		public MaterialsDataGridForm(IDbWorker dbWorker)
		{
			InitializeComponent();
			_dbWorker = dbWorker;
		}
	}
}
