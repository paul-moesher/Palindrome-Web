using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool result;

            try
            {
                Console.Write("Input a word to test if its a palindrome: ");
                userInput = Console.ReadLine();

                result = PalindromeChecker.IsPalindrome(userInput);
                if (result == true)
                {
                    Console.WriteLine("The word is a Palindrome. \n");
                }
                else
                {
                    Console.WriteLine("The word is NOT a Palindrome. \n");
                }

                do
                {
                    Console.Write("Enter another word to test or type Exit to end: ");
                    userInput = Console.ReadLine();

                    if (userInput == "Exit")
                    {
                        break;
                    }

                    result = PalindromeChecker.IsPalindrome(userInput);
                    if (result == true)
                    {
                        Console.WriteLine("The word is a Palindrome. Press enter to contiune. \n");
                    }
                    else
                    {
                        Console.WriteLine("The word is NOT a Palindrome. Press enter to contiune. \n");
                    }
                } while (userInput != "Exit");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please contact System Administrator");
            }
        }


        public class PalindromeChecker
        {
            public static bool IsPalindrome(string userInput)
            {
                try
                {
                    if (userInput.Length <= 1)
                        return true;
                    else
                    {
                        if (userInput[0] != userInput[userInput.Length - 1])
                            return false;
                        else
                            return IsPalindrome(userInput.Substring(1, userInput.Length - 2));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please contact System Administrator");
                    return false;
                }
            }
        }
    }
}
