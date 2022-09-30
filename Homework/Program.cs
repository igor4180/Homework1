using System;

namespace Homework
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Task1
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(num));
            Console.ReadKey(true);
            static bool IsPalindrome(int num)
            {
                if (num >= 0 && num < 10)
                    return true;
                int numLength = GetLength(num);
                int[] digits = new int[numLength];
                for (int i = numLength - 1; i >= 0; i--)
                {
                    digits[i] = num % 10;
                    num /= 10;
                }
                for (int i = 0; i < numLength / 2; i++)
                {
                    if (digits[i] != digits[numLength - i - 1])
                        return false;

                }
                return true;
            }

            static int GetLength(int num)
            {
                int n = 0;
                while (num > 0)
                {
                    num /= 10;
                    n++;
                }
                return n;
            }
            #endregion
        }

    }
}