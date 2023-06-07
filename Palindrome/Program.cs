using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"{arg,8} -> {Program.Palindrome(arg)}");
            }
        }

        static bool Palindrome(string testing)
        {
            bool CheckedPalindrome(string testing)
            {
                if (testing.EndsWith(testing[0]))
                {
                    testing=testing.Remove(0, 1);
                    testing=testing.Remove(testing.Length-1, 1);

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
