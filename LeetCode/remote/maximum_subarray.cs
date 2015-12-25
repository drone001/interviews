//  https://leetcode.com/problems/maximum-subarray/
//
//   Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
//
//   For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
//   the contiguous subarray [4,−1,2,1] has the largest sum = 6. 

using System;

public class Solution {
    // TLE
    public int MaxSubArray(int[] nums) {
        var pre = new int[nums.Length];
        pre[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            pre[i] = nums[i] + pre[i - 1];
        }

        var max = int.MinValue;
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j <= i; j++)
            {
                max = Math.Max(max, pre[i] - pre[j] + nums[j]);
            }
        }

        return max;
    }

    public int MaxSubArray2(int[] nums)
    {
        return 0;
    }

    static void Main()
    {
        Console.WriteLine(new Solution().MaxSubArray(new [] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        Console.WriteLine(new Solution().MaxSubArray2(new [] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
    }
}
