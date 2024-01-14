

using Bank.classes;
using Bank.interfaces;

namespace Bank.modules
{

    public class UserService : IUser
    {
        private List<User> users = new List<User>
        {
        new User("Hojimurod", "Abdurahmonov", 25,"AA16437", "1230"),
        new User("Jane", "Smith", 30,"AA16438", "password2"),

        };

        public void SignIn()
        {
            Console.WriteLine("Enter your First Name: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter your Last Name: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your PasportSeria Name: ");
            string passid = Console.ReadLine();

            Console.WriteLine("Create a password: ");
            string pass = Console.ReadLine();


            User foydalanuvchi = new(fname, lname, age, passid, pass);
            users.Add(foydalanuvchi);
            Console.WriteLine("Foydalanuvchi muvaffaqiyatli qoshildi!!!");

        }
        public void LogIn()
        {
            Console.WriteLine("Enter your Password: ");
            string pass = Console.ReadLine();
            bool flag = false;
            int a;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Password == pass)
                {
                    flag = true;
                    a = i;
                }
            }
            Console.Clear();
            Console.WriteLine(flag == true ? $"=============================================Yo successful Log in Welcome=========================================== " : "You must sign in");


        }

        public void ShowAllUsers()
        {
            Console.Clear();

            Console.WriteLine("================================================ Users table ================================================");
            Console.WriteLine();
            Console.WriteLine($"U/R\tName\t\tSurname\t\tAge\t\tPassport\t\tPassword ");
            Console.WriteLine(new string('-', 120));

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1,2}.\t{users[i].FirstName,-15}{users[i].LastName,-15}{users[i].Age,-18}{users[i].PassportId,-18}{users[i].Password}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
