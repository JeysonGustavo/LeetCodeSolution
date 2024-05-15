namespace ConsoleAppTest.Problems.Easy
{
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            int input = x, output = 0;

            if (x < 0)
                return false;

            while (input != 0)
            {
                int num = input % 10;
                output = (output * 10) + num;
                input = input / 10;
            }

            return x == output;
        }
    }
}
