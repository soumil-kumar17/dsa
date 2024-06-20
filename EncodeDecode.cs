namespace NeetcodeBlind75;

public partial class Solution
{
    public string Encode(IList<string> strs)
    {
        return string.Concat(strs.SelectMany(s => $"{s.Length}?{s}"));
    }

    public List<string> Decode(string s)
    {
        List<string> res = new();
        int i = 0;
        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '?')
            {
                j++;
            }
            var success = int.TryParse(s.AsSpan(i, j - 1), out var len);
            j++;
            if (success)
            {
                res.Add(s.Substring(j, len));
            }
            i = j + len;
        }
        return res;
    }
}