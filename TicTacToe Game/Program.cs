using System;

namespace TicTacToe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            int count = 0;
            char symbl;
            do
            {
                
                Console.WriteLine(game);

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

                Console.Write("\n99 - step back\nEner num (0-9) : ");
                int.TryParse(Console.ReadLine(), out int num);
                Console.Clear();
                if (num==99)
                {
                    if (game.BackHistory())
                    {
                        count--;
                    }
                    else { Console.WriteLine("Don't back"); }
                }else if (count % 2 == 0)
                {
                    if (game.MakeMove(num, symbl))
                    {
                        count++;
                        if (game.CheckWin('X')) break;
                    }
                    else Console.WriteLine("Number entered incorrectly");
                }
                else
                {
                    if (game.MakeMove(num, symbl))
                    {
                        count++;
                        if (game.CheckWin('Y')) break;
                    }
                    else Console.WriteLine("Number entered incorrectly");

                }
                
            } while (true);

            Console.Clear();
            Console.WriteLine(game);
            Console.WriteLine($"{symbl} is win!!!");
        }
    }
}
