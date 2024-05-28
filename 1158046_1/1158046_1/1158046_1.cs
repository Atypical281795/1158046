using System;

class NumberConversionTable
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0,-8} {1,-10} {2,-6} {3,-12}", "Decimal", "Binary", "Octal", "Hexadecimal");
        for (int i = 1; i <= 256; i++)
        {
            string binary = Convert.ToString(i, 2);
            string octal = DecimalToOctal(i);
            string hexadecimal = Convert.ToString(i, 16).ToUpper();

            Console.WriteLine("{0,-8} {1,-10} {2,-6} {3,-12}", i, binary, octal, hexadecimal);
        }
        Console.Read();
    }

    static string DecimalToOctal(int decimalNumber)
    {
        int remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 8;
            decimalNumber /= 8;
            result = remainder.ToString() + result;
        }
        return result;
    }
}
