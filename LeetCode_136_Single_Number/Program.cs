namespace LeetCode_136_Single_Number;

internal class Program
{

        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++) {
                result += nums[i];
        }
        return result; 
        }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
