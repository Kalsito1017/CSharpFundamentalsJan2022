using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool ispasswordLenghtValid = ValidatePasswordLenght(password);
            bool isPasswordContainsValidSymbols = ValidatePasswordText(password);
            bool IsDigitInPasswordAtLeastTwo = ValidatePasswordDigit(password);
            if (!ispasswordLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsDigitInPasswordAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isPasswordContainsValidSymbols && ispasswordLenghtValid && IsDigitInPasswordAtLeastTwo)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePasswordLenght(string text)
        {
            return text.Length >= 6 && text.Length <= 10;
        }
        static bool ValidatePasswordText(string text)
        {

            foreach (char character in text)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }
        static bool ValidatePasswordDigit(string text)
        {
            int countDigit = 0;
            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    countDigit++;
                }
            }
            return countDigit >= 2;
        }
    }
}
