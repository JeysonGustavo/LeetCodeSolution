using ConsoleAppTest.Problems.Easy;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CallTwoSum();
            //CallPalindromeNumber();
            //CallRomanToInt();

            Console.WriteLine("Finished!");
            Console.ReadKey();
        }

        private static void CallTwoSum()
        {
            //int[] nums = [2, 7, 11, 15];
            //int target = 9;
            int[] nums = [3, 2, 4];
            int target = 6;

            TwoSumSolution solution = new TwoSumSolution();

            int[] output = solution.TwoSum(nums, target);

            Console.WriteLine($"[{output[0]},{output[1]}]");
        }

        private static void CallPalindromeNumber()
        {
            //int x = 121;
            int x = -121;

            PalindromeNumberSolution solution = new PalindromeNumberSolution();

            bool output = solution.IsPalindrome(x);

            Console.WriteLine(output);
        }

        private static void CallRomanToInt()
        {
            string s = "MCMXCIV";

            RomanToIntegerSolution solution = new RomanToIntegerSolution();
            int output = solution.RomanToInt(s);

            Console.WriteLine(output);
        }
    }
}
