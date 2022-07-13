namespace Study1
{
    class user
    {
        private static int id;
        private string name;
        private string email;
        private string password;

        static public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { if (name != null) name = value; }
        }

        public string Email
        {
            get { return email; }
            set { if (email != null) email = value; }
        }

        public string Password
        {
            get { return password; }
            set { if (password != null) password = value; }
        }

        public void Show() { Console.WriteLine("\n   ID = " + Id + "\n   Name = " + Name + "\n   Email = " + Email + "\n   Password = " + Password); }

        public void ChangePassword()
        {
            Random rnd = new Random();
            string _password = "";
            for (int i = 0; i < 16; i++)
            {
                _password = _password + Convert.ToString((rnd.Next(0, 9)));
            }
            Password = _password;
        }

        public void ChangePassword(string _password) { Password = _password; }

        static user() { id = 0; }

        public user(string name, string email, string password)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            id++;
        }
    }
}