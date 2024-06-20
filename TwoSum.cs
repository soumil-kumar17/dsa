namespace NeetcodeBlind75;

public partial class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var mp = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (mp.TryGetValue(complement, out var value))
            {
                return [value, i];
            }
            if (!mp.ContainsKey(nums[i]))
            {
                mp[nums[i]] = i;
            }
        }
        return [-1, -1];
    }
}