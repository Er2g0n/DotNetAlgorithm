namespace LeetCode_108_Convert_Sorted_Array_to_Binary_Search_Tree;

// Define the TreeNode class to resolve CS0246
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

internal class Program
{
    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return helper(nums, 0, nums.Length - 1);
        }

        private TreeNode helper(int[] nums, int start, int end)
        {
            if (start > end) return null;

            int mid = start + (end - start) / 2;

            // Simplify object initialization to resolve IDE0017
            var root = new TreeNode
            {
                val = nums[mid],
                left = helper(nums, start, mid - 1),
                right = helper(nums, mid + 1, end)
            };

            return root;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
