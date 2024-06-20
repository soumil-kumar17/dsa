namespace NeetcodeBlind75;

public partial class Solution
{
    private int[]? _ansArr;
    public int[] ProductExceptSelf(int[] nums)
    {
        _ansArr = new int[nums.Length];
        int curr = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            _ansArr[i] = curr;
            curr *= nums[i];
        }
        curr = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            _ansArr[i] *= curr;
            curr *= nums[i];
        }
        return _ansArr;
    }
}