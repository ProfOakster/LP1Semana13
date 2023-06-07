using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static bool Palindrome(string testing)
        {
            bool CheckedPalindrome(string testing)
            {
                if (testing.EndsWith(testing[0]))
                {
                    testing.Remove(0, 1);
                    testing.Remove(testing.Length, 1);
                    
                    return Program.Palindrome(testing);
                }
                else
                    return false;
            }


            if (testing is null)
            {
                throw new ArgumentNullException();
            }
            else if (testing.Length<2)
            {
                return true;
            }
            else
                return CheckedPalindrome(testing);
        }



    }   

}
