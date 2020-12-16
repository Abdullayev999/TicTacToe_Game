namespace TicTacToe_Game
{
    class TicTacToe
    {
        private char[] Board { get; set; }
        private const int Count = 9;
        public TicTacToe()
        {
            Board = new char[Count] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
        }
        public bool ChekWin(char symbl)
        {
            for (int i = 0; i < 7; i += 3)// check horizontally
            {
                if (Board[i] == symbl && Board[i + 1] == symbl && Board[i + 2] == symbl)
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)//check vertically
            {
                if (Board[i] == symbl && Board[i + 3] == symbl && Board[i + 6] == symbl)
                {
                    return true;
                }
            }

            if ((Board[0] == symbl && Board[4] == symbl && Board[8] == symbl) || //check obliquely
               (Board[2] == symbl && Board[4] == symbl && Board[6] == symbl))
            {
                return true;
            }
            return false;
        }
        public bool MakeMove(int x, char symbl)
        {
            if (x >= 0 && x <= 8)
            {
                if (Board[x] == ' ')
                {
                    Board[x] = symbl;
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Count; i++)
            {
                str += "| ";
                if (Board[i] != ' ')
                    str += Board[i];
                else
                {
                    str += " ";
                }
                str += " |";

                if ((i + 1) % 3 == 0)
                {
                    str += "\n";
                }
            }
            return str;
        }
    }
}
