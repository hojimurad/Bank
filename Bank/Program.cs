using Bank.interfaces;
using Bank.modules;

class Program
{
    static void Main()
    {
        IUser user = new UserService();
        ICard card = new CardService();

        bool kirish = true;

        while (true)
        {
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Log in");
            Console.WriteLine("3. Show all users");
            Console.WriteLine("4. Clear");
            Console.WriteLine("5. Exit");

            int b = int.Parse(Console.ReadLine());

            switch (b)
            {
                case 1:
                    user.SignIn();
                    break;

                case 2:
                    user.LogIn();
                    Console.Clear();

                    while (kirish)
                    {
                        Console.WriteLine("""
                            =====================================================
                                        welcome HojiuradIndustris Bank
                            =====================================================

                            Buyruqlardan birini kiriting:
                            1. Create new card
                            2. My cards
                            3. Payment to my card
                            4. Payment from my card
                            5. Block or Unblok  card
                            6. Exit
                        """);

                        int num = int.Parse(Console.ReadLine());

                        switch (num)
                        {
                            case 1:
                                {
                                    card.CreateMyCard();
                                }
                                break;
                            case 2: card.GetMyCards(); break;
                            case 3: card.PaymetToCard(); break;
                            case 4: card.PaymetFromCard(); break;
                            case 5: card.BlokOrUnblokCard(); break;
                            case 6:
                                kirish = false;
                                break;
                        }
                    }
                    break;

                case 4:
                    Console.Clear();
                    break;

                case 3:
                    user.ShowAllUsers();
                    break;

                case 5:
                    kirish = false;
                    break;
            }
        }
    }
}
