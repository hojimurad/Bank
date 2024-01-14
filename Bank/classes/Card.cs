namespace Bank.classes
{
    public class Card
    {
        public string CardNum { get; }
        public string Muddat { get; }
        public string Pass { get; }
        private int _balance;
        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        private bool _isActive;

        public bool Active
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }


        public Card(string muddat, string pass)
        {
            Muddat = muddat;
            Pass = pass;
            CardNum = GetNum();
            Active = true;
            Balance = 10;

        }

        private static string GetNum()
        {
            string numberCard = "";
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                numberCard += random.Next(0, 9999).ToString("D4"); // Ensure 4-digit numbers
                if (i < 3) numberCard += " ";
            }

            return numberCard;
        }
    }
}
