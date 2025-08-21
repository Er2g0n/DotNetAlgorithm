namespace LeetCode_27_Remove_Element;

internal class Program
{


    public static int RemoveElement(int[] nums, int val) 
    {
        
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];

                k++;
            }
        }
        return k;
    }
    static void Main()
    {
        Console.WriteLine("Enter an array of integers,separated by spaces (eg: 3 2 2 3): ");
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        int[] nums = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            nums[i] = int.Parse(parts[i]);

        }

        Console.WriteLine("Input number need to remove: ");
        int val = int.Parse(Console.ReadLine());

        int k = RemoveElement(nums,val);

        Console.Write("Array after remove: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }

    }
}
