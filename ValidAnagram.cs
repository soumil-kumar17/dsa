namespace NeetcodeBlind75;

public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var count = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (!count.TryAdd(c, 1))
            {
                count[c]++;
            }
        }
        foreach (var c in t)
        {
            if (!count.TryAdd(c, -1))
            {
                count[c]--;
            }
        }
        foreach (var kvp in count)
        {
            if (kvp.Value != 0)
            {
                return false;
            }
        }
        return true;
    }
}