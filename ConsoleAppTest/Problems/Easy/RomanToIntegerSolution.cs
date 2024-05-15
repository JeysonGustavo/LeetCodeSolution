namespace ConsoleAppTest.Problems.Easy
{
    public class RomanToIntegerSolution
    {
        private Dictionary<string, int> NumeralsList = new Dictionary<string, int>()
        {
            {"M", 1000 },
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1},
        };

        public int RomanToInt(string s)
        {
            int sum = 0, i = 0;
            char[] arr = s.ToArray();

            while (i < arr.Length)
            {
                string symbol = arr[i].ToString();
                char firstSymbol = arr[i];

                if (i < arr.Length - 1)
                {
                    char nextSymbol = arr[i + 1];

                    if (firstSymbol == 'I' && (nextSymbol == 'V' || nextSymbol == 'X') ||
                        firstSymbol == 'X' && (nextSymbol == 'L' || nextSymbol == 'C') ||
                        firstSymbol == 'C' && (nextSymbol == 'D' || nextSymbol == 'M'))
                    {
                        symbol = string.Concat(symbol.ToString(), nextSymbol.ToString());
                        i++;
                    }
                }

                int numeralValue = NumeralsList[symbol];

                sum += numeralValue;

                i++;
            }

            return sum;
        }
    }
}
