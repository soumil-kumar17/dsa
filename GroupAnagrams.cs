namespace NeetcodeBlind75;

public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] words)
    {
        var anagramGroups = new Dictionary<string, List<string>>();
        foreach (var word in words)
        {
            var charArray = word.ToCharArray();
            Array.Sort(charArray);
            var key = new string(charArray);
            if (!anagramGroups.TryGetValue(key, out var value))
            {
                anagramGroups[key] = new List<string> { word };
            }
            else
            {
                value.Add(word);
            }
        }
        return new List<IList<string>>(anagramGroups.Values);
    }
}