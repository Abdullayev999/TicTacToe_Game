using System;

namespace TicTacToe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe tmp = new TicTacToe();
            Console.WriteLine(tmp);
            int count = 0;
            char symbl;
            do
            {
                Console.Clear();
                Console.WriteLine(tmp);

                if (count % 2 == 0)
                {
                    Console.Write("symbl : X");
                    symbl = 'X';
                }
                else
                {
                    Console.Write("symbl : Y");
                    symbl = 'Y';
                }

                Console.Write("\nEner num (0-9) : ");
                int.TryParse(Console.ReadLine(), out int num);

                if (count % 2 == 0)
                {
                    if (tmp.MakeMove(num, symbl))
                    {
                        count++;
                        if (tmp.ChekWin('X')) break;
                    }
                    else Console.WriteLine("Number entered incorrectly");
                }
                else
                {
                    if (tmp.MakeMove(num, symbl))
                    {
                        count++;
                        if (tmp.ChekWin('Y')) break;
                    }
                    else Console.WriteLine("Number entered incorrectly");

                }
            } while (true);

            Console.Clear();
            Console.WriteLine(tmp);
            Console.WriteLine($"{symbl} is win!!!");
        }
    }
}
