namespace NeetcodeBlind75;

public partial class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        
        Array.Sort(nums);
        int count = 1;
        int maxCount = 1;
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] + 1 == nums[i + 1])
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            else if (nums[i] != nums[i + 1])
            {
                count = 1;
            }
        }
        return maxCount;
    }
}