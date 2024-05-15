namespace ConsoleAppTest.Problems.Easy
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int j = 0, i = 0, sum = target + 1;

            while (sum != target)
            {
                j++;

                if (j == nums.Length)
                {
                    i++;
                    j = i + 1;
                }

                sum = nums[i] + nums[j];
            }

            return [i, j];
        }
    }
}
