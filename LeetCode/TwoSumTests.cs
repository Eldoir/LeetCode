namespace LeetCode;

internal class TwoSumTests
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }

        throw new InvalidOperationException();
    }

    [TestCase(new int[] {0, 1}, new int[] {2, 7, 11, 15}, 9)]
    [TestCase(new int[] {1, 2}, new int[] {3, 2, 4}, 6)]
    [TestCase(new int[] {0, 1}, new int[] {3, 3}, 6)]
    public void Cases(int[] expected, int[] nums, int target)
    {
        CollectionAssert.AreEqual(expected, TwoSum(nums, target));
    }
}
