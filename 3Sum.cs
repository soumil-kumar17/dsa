namespace NeetcodeBlind75;

public partial class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        if (nums.Length < 3)
        {
            return res;
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];

                switch (sum)
                {
                    case 0:
                    {
                        res.Add(new List<int> { nums[i], nums[j], nums[k] });

                        while (j < k && nums[j] == nums[j + 1])
                        {
                            j++;
                        }
                        while (j < k && nums[k] == nums[k - 1])
                        {
                            k--;
                        }

                        j++;
                        k--;
                        break;
                    }
                    case < 0:
                        j++;
                        break;
                    default:
                        k--;
                        break;
                }
            }
        }

        return res;
    }
}