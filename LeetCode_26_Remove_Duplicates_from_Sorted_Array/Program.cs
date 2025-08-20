namespace LeetCode_26_Remove_Duplicates_from_Sorted_Array;

internal class Program
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;

        int uniqueIndex = 0; // Index to place the next unique element

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueIndex])
            {
                uniqueIndex++;
                nums[uniqueIndex] = nums[i];
            }
        }

        return uniqueIndex + 1; // Return the count of unique elements
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 3, 4, 5, 6, 7 };
        int length = RemoveDuplicates(nums);

        Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }
}
