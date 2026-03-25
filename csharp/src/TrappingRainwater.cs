/// <summary>
/// LeetCode 42 - Trapping Rain Water
///
/// Given n non-negative integers representing an elevation map where the width of each bar is 1,
/// compute how much water it can trap after raining.
///
/// Approach: Two-pointer technique — O(n) time, O(1) space
/// </summary>
public class TrappingRainwater
{
    public int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int maxLeft = 0, maxRight = 0;
        int water = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= maxLeft)
                    maxLeft = height[left];
                else
                    water += maxLeft - height[left];
                left++;
            }
            else
            {
                if (height[right] >= maxRight)
                    maxRight = height[right];
                else
                    water += maxRight - height[right];
                right--;
            }
        }

        return water;
    }

    public static void Main(string[] args)
    {
        var solution = new TrappingRainwater();
        System.Console.WriteLine(solution.Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 })); // Expected: 6
        System.Console.WriteLine(solution.Trap(new int[] { 4, 2, 0, 3, 2, 5 }));                    // Expected: 9
    }
}
