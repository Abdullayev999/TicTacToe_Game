using System.Collections.Generic;

namespace TicTacToe_Game
{
    /*
       + Реализовать игру Крестик-Нолик
       + Возможность с откатом назад
    */
    class TicTacToe
    {
        private List<int> History { get; set; }
        private char[] Board { get; set; }
        private const int Count = 9;
        public TicTacToe()
        {
            History = new List<int>();

            Board = new char[Count] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };
            
        }

        public bool BackHistory()
        {
            if (History.Count > 0)
            {
                int count = History.Count - 1;
                int number = History[count];
                History.RemoveAt(count);

                Board[number] = ' ';

                return true;
            }
            return false;
        }
        public bool CheckWin(char symbl)
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
                    History.Add(x);
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
