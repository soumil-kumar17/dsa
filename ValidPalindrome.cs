namespace NeetcodeBlind75;

public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        
        s = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}