//  https://leetcode.com/problems/path-sum-ii/
//
//   Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum. 

using System;
using System.Collections.Generic;
using System.Linq;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        if (root == null || root.val > sum)
        {
            return new List<IList<int>>();
        }

        if (sum == root.val && root.left == null && root.right == null)
        {
            return new List<IList<int>> { new List<int> { root.val } };
        }

        var result = new List<IList<int>>();
        var current = new List<int> { root.val };
        if (root.left != null)
        {
            var left = PathSum(root.left, sum - root.val);
            if (left.Any())
            {
                result = result.Concat(left.Select(x => current.Concat(x).ToList()).ToList()).ToList();
            }
        }

        if (root.right != null)
        {
            var right = PathSum(root.right, sum - root.val);
            if (right.Any())
            {
                result = result.Concat(right.Select(x => current.Concat(x).ToList()).ToList()).ToList();
            }
        }

        return result;
    }

    static void Main()
    {
        var root = new TreeNode(1) {
            left = new TreeNode(2) {
                right = new TreeNode(1)
            },
            right = new TreeNode(3)
        };

        Console.WriteLine(String.Join(Environment.NewLine, new Solution().PathSum(root, 4).Select(x => String.Join(", ", x))));

        root = new TreeNode(-2) {
            right = new TreeNode(-3)
        };

        Console.WriteLine(String.Join(Environment.NewLine, new Solution().PathSum(root, -5).Select(x => String.Join(", ", x))));
    }
}
