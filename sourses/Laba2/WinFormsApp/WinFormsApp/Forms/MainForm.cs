using WinFormsApp.Database;

namespace WinFormsApp
{
	public partial class MainForm : Form
	{
		private readonly ShopDBContext _db;
		public MainForm()
		{
			InitializeComponent();
			_db = new ShopDBContext();
		}


		//if(tbPassword.Text = tbPasswordAgain.Text)
		//{
		//	MessageBox.Show("пароли должны быть одинаковы");
		//	return;
		//}

		//if (_db.Users.Where(x=>x.Login))

		//string Login = tbLogin.Text;
		//UserPassword password = tbPassword.Text;

		//var succesful = _db.Users.Where(x=>x.Login == Login && x.Password == password).Any();


		// if(succesful){ DialogResult = DialogResult.OK}
	}


}
