

namespace Bank.classes
{

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        private string _passportId;

        private string _password;

        public string PassportId
        {
            get { return _passportId; }
            set { _passportId = value; }
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }


        public User(string firstName, string lastName, int age, string passportId, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PassportId = passportId;
            Password = password;
        }
    }

}
