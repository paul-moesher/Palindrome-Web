using System;

namespace Palindrome
{
    internal class Palindrome
    {
            public bool IsPalindrome(string userInput)
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