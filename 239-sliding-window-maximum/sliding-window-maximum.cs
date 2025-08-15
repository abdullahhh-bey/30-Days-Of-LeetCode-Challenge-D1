public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return new int[0];

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>(); // store indexes

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove elements from back if they are smaller than current
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            // Add current index to deque
            deque.AddLast(i);

            // Remove front if it's outside the current window
            if (deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Start adding results after the first window is complete
            if (i >= k - 1)
            {
                result.Add(nums[deque.First.Value]);
            }
        }

        return result.ToArray();
    }
}
