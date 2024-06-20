namespace NeetcodeBlind75;

public partial class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freqDict = new Dictionary<int, int>();
        foreach (var x in nums)
        {
            if (!freqDict.TryGetValue(x, out var value))
            {
                freqDict.Add(x, 1);
            }
            else
            {
                freqDict[x] = ++value;
            }
        }
        var minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => x.CompareTo(y)));
        foreach (var kvp in freqDict)
        {
            minHeap.Enqueue(kvp.Key, kvp.Value);
            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }
        var result = new int[k];
        for (var i = k - 1; i >= 0; i--)
        {
            result[i] = minHeap.Dequeue();
        }
        return result;
    }
}