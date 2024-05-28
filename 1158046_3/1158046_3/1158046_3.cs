using System;

class DiceRollingSimulation
{

    static void Main(string[] args)
    {
        const int numberOfRolls = 36000;
        const int maxSum = 12;
        int[] frequencies = new int[maxSum + 1];
        Random random = new Random();

        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;
            frequencies[sum]++;
        }

        Console.WriteLine("{0,4} {1,10} {2,10}", "Sum", "Frequency", "Percentage");
        for (int sum = 2; sum <= maxSum; sum++)
        {
            double percentage = (double)frequencies[sum] / numberOfRolls * 100;
            Console.WriteLine("{0,4} {1,10} {2,10:F2}", sum, frequencies[sum], percentage);
        }
        Console.Read();
    }
}
