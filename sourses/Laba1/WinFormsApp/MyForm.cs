namespace WinFormsApp
{
	public partial class MyForm : Form
	{
		public MyForm()
		{
			InitializeComponent();

			foreach (var n in Enumerable.Range(1, 10))
			{
				var newControl = new MyUserControl1()
				{
					Label = $"control{n}"
				};

				newControl.Location = new Point(5, 5 + n * (newControl.Size.Height + 5));

				Controls.Add(newControl);
			}
		}


		private void myComponent_Tick(object sender, EventArgs e)
		{
			//Console.WriteLine($"DateTime.NOW");
		}
	}
}
