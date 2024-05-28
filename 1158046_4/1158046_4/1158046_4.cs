using System;

class Program
{
    internal class craps
    {
        private static Random randomNumbers = new Random();
        private enum Status { Continue, Won, Lose }
        static void Main(string[] args)
        {
            Status gameStatus = Status.Continue;

            var won = new int[22];
            var lose = new int[22];
            for (int rollNumber = 1; rollNumber <= 1000; rollNumber++)
            {
                int myPoint = 0;
                int round = 1;
                int dice = RollDice();
                switch (dice)
                {
                    case 7:
                    case 11:
                        gameStatus = Status.Won;
                        won[round]++;
                        break;
                    case 2:
                    case 3:
                    case 12:
                        gameStatus = Status.Lose;
                        lose[round]++;
                        break;
                    default:
                        gameStatus = Status.Continue;
                        myPoint = dice;
                        break;
                }
                round++;
                while (gameStatus == Status.Continue)
                {
                    dice = RollDice();
                    if (round > 20)
                    {
                        round = 21;
                    }
                    if (dice == myPoint)
                    {
                        gameStatus = Status.Won;
                        won[round]++;
                    }
                    else
                    {
                        if (dice == 7)
                        {
                            gameStatus = Status.Lose;
                            lose[round]++;
                        }
                    }
                    round++;
                }
            }
            int winGames = 0;
            int loseGames = 0;
            int length = 0;
            for (int countGames = 1; countGames <= 21; countGames++)
            {
                winGames += won[countGames];
                loseGames += lose[countGames];
            }
            int totalGames = winGames + loseGames;
            for (int i = 1; i <= 21; i++)
            {
                if (i == 21)
                {
                    Console.Write($"{won[i]} games won and {lose[i]} games lost");
                    Console.WriteLine(" on rolls after the 20th roll");
                }
                else
                {
                    Console.Write($"{won[i]} games won and {lose[i]} games lost");
                    Console.WriteLine($" on roll #{i}");
                }
                length += won[i] * i + lose[i] * i;
            }
            Console.Write("\nThe chances of winning are ");
            Console.WriteLine($"{winGames}/{totalGames}={(100.0 * winGames / totalGames):F}%");
            Console.WriteLine($"The average game length is {((double)length / totalGames):F} rolls.");
            Console.Read();
        }
        public static int RollDice()
        {
            int dice1 = randomNumbers.Next(1, 7);
            int dice2 = randomNumbers.Next(1, 7);
            int sum = dice1 + dice2;
            return sum;
        }
    }
}