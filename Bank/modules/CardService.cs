using Bank.classes;
using Bank.interfaces;

namespace Bank.modules
{
    public class CardService : ICard
    {
        private List<Card> Mycards = new List<Card>
            {
                new Card("12/25", "1234"), // Default Card 1
                new Card("06/23", "5678")  // Default Card 2
            };

        public void BlokOrUnblokCard()
        {
            Console.WriteLine("enter number your card: ");
            string numberCard = Console.ReadLine();
            Console.WriteLine("enter password: ");
            string pass = Console.ReadLine();
            bool f = false;
            int index = 0;
            for (int i = 0; i < Mycards.Count; i++)
            {
                if (Mycards[i].CardNum == numberCard && Mycards[i].Pass == pass)
                {
                    f = true;
                    index = i;
                }
            }
            if (f)
            {

                if (Mycards[index].Active)
                {
                    Mycards[index].Active = false;
                    Console.WriteLine("Carta bloklandi");
                }
                else
                {
                    Mycards[index].Active = true;
                    Console.WriteLine("Carta blokdan chiqarildi");
                }


            }
            else
            {
                Console.WriteLine("Bunday card topilmadi");
            }

        }

        public void CreateMyCard()
        {
            Console.WriteLine("Creating new card ....");
            Console.WriteLine("Enter card date (05/25)");
            string muddat = Console.ReadLine();
            Console.WriteLine("Create new password (1234) : ");
            string pass = Console.ReadLine();
            Card card = new Card(muddat, pass);
            Mycards.Add(card);

            Console.WriteLine("You create a new card=========");
        }

        public void GetMyCards()
        {
            Console.Clear();

            Console.WriteLine("================================================ Cards table ================================================");
            Console.WriteLine();
            Console.WriteLine($"C/R\t\tNumber\t\tBalance\tMuddat\t\t\t\t\tPassword\t\tAction ");
            Console.WriteLine(new string('-', 120));

            for (int i = 0; i < Mycards.Count; i++)
            {
                Console.WriteLine($"{i + 1,2}.\t{Mycards[i].CardNum,-15}\t{Mycards[i].Balance,-25}{Mycards[i].Muddat,-18}{Mycards[i].Pass,-18}{Mycards[i].Active}");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void PaymetFromCard()
        {
            Console.WriteLine("enter number your card: ");
            string numberCard = Console.ReadLine();
            Console.WriteLine("enter password: ");
            string pass = Console.ReadLine();
            bool f = false;
            int index = 0;
            for (int i = 0; i < Mycards.Count; i++)
            {
                if (Mycards[i].CardNum == numberCard && Mycards[i].Pass == pass)
                {
                    f = true;
                    index = i;
                }
            }
            if (f)
            {
                Console.WriteLine("Enter payment from this card: ");
                int sum = int.Parse(Console.ReadLine());
                if (sum <= Mycards[index].Balance)
                {
                    Mycards[index].Balance -= sum;
                    Console.WriteLine("Pul yechib olindi");

                }
                else
                {
                    Console.WriteLine("Yetarli mablag mavjud emas");
                }


            }
            else
            {
                Console.WriteLine("Bunday card topilmadi");
            }
        }

        public void PaymetToCard()
        {
            Console.WriteLine("enter number your card: ");
            string numberCard = Console.ReadLine();
            Console.WriteLine("enter password: ");
            string pass = Console.ReadLine();
            bool f = false;
            int index = 0;
            for (int i = 0; i < Mycards.Count; i++)
            {
                if (Mycards[i].CardNum == numberCard && Mycards[i].Pass == pass)
                {
                    f = true;
                    index = i;
                }
            }
            if (f)
            {
                Console.WriteLine("Enter payment to this card: ");
                int sum = int.Parse(Console.ReadLine());
                Mycards[index].Balance = sum;
                Console.WriteLine("Pul otkazildi");

            }
            else
            {
                Console.WriteLine("Bunday card topilmadi");
            }
        }


    }
}
