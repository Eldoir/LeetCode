namespace LeetCode;

internal class LongestSubstringWithoutRepeatingCharactersTests
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> charSet = [];
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (charSet.Contains(s[right]))
            {
                charSet.Remove(s[left]);
                left++;
            }
            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }

    [TestCase(0, "")]
    [TestCase(1, " ")]
    [TestCase(3, "abcabcbb")]
    [TestCase(1, "bbbbb")]
    [TestCase(3, "pwwkew")]
    [TestCase(3, "dvdf")]
    public void Cases(int expected, string s)
    {
        Assert.AreEqual(expected, LengthOfLongestSubstring(s));
    }
}
