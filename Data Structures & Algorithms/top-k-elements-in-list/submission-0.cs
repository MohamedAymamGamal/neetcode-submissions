public class Solution {
   public int[] TopKFrequent(int[] nums, int k)
{
    // Count frequency
    Dictionary<int, int> freq = new();

    foreach (int num in nums)
    {
        if (freq.ContainsKey(num))
            freq[num]++;
        else
            freq[num] = 1;
    }

    // Min Heap
    PriorityQueue<int, int> heap = new();

    foreach (var pair in freq)
    {
        heap.Enqueue(pair.Key, pair.Value);

        if (heap.Count > k)
            heap.Dequeue();
    }

    int[] result = new int[k];

    for (int i = k - 1; i >= 0; i--)
    {
        result[i] = heap.Dequeue();
    }

    return result;
}

}
