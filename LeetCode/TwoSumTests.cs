namespace LeetCode.Tests;

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

    [Test]
    public void Case1()
    {
        CollectionAssert.AreEqual(new int[] { 0, 1 }, TwoSum([2, 7, 11, 15], 9));
    }

    [Test]
    public void Case2()
    {
        CollectionAssert.AreEqual(new int[] { 1, 2 }, TwoSum([3, 2, 4], 6));
    }

    [Test]
    public void Case3()
    {
        CollectionAssert.AreEqual(new int[] { 0, 1 }, TwoSum([3, 3], 6));
    }
}
