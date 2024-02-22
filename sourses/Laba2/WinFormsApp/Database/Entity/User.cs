using WinFormsApp.Extentions;

namespace WinFormsApp.Database.Entity
{
    class User
    {
        public int ID{ get; set; }
        public string Login { get; set; }
        public UserPassword Password { get; set; }

    }

    //ddd - domen drived db
    class UserPassword
    {
        private string _password = string.Empty;
        
        public string Password 
        {
            get => _password;
            set => _password = value.ToHash();
        }

        public static bool operator == (UserPassword left, UserPassword right)
        {
            if (left is null || right is null) return false;
            return left._password == right._password;
        }
		public static bool operator !=(UserPassword left, UserPassword right)
		{
			return !(left == right);
		}

		public static implicit operator string (UserPassword password) => password.Password;
		public static implicit operator UserPassword(string password) => new() { Password = password };

	}
}
