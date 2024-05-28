using System;

class RecursiveSumCalculation
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter the Number (between 10 - 99999): ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 10 && number <= 99999)
                {
                    int sum = SumOfDigits(number);
                    Console.WriteLine("Sum of Digits in {0} is {1}", number, sum);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid number");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
        Console.Read();
    }

    static int SumOfDigits(int number)
    {
        if (number < 10)
            return number;
        else
            return (number % 10) + SumOfDigits(number / 10);
    }
}
