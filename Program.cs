using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    { // Convert a binary to decimal with Horner Scheme
        static void Main(string[] args)
        {
            Console.Write("Enter one binary number: ");

            string binaryString = Console.ReadLine();

            int decimalNumber = ConvertBinaryStringToDecimal(binaryString);

            Console.Write("The binary number {0} is {1} in decimal number.", binaryString, decimalNumber);

            Console.ReadKey();
        }

        static int ConvertBinaryStringToDecimal(string binaryString)
        {
            char[] binaryChars = binaryString.ToCharArray();

            int number = int.Parse(binaryChars[0].ToString());

            for (int i = 0; i < binaryChars.Length - 1; i++)
            {
                int nextBitDigit = int.Parse(binaryChars[i + 1].ToString());

                number = number * 2 + nextBitDigit;
            }

            return number;
        }
    }
}
