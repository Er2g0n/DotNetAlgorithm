using System.Text;

namespace LeetCode_14_Longest_Common_Prefix;

internal class Program
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";
        Array.Sort(strs);
        string first = strs[0], last = strs[strs.Length - 1];
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < first.Length; i++)
        {
            if (i < last.Length && first[i] == last[i])
            {
                result.Append(first[i]);
            }
            else
            {
                break;
            }
        }
        return result.ToString();
    }


    static void Main(string[] args)
    {

        //string[] strs = { "flower", "flow", "flight" };
        //string[] strs = { "dog", "racecar", "car" };
        Console.WriteLine("Enter the number of strings\r\n: ");
        int n = int.Parse(Console.ReadLine());

        string[] strs = new string[n];

        for (int i = 0;i < n;i++)
        {
            Console.WriteLine($"Enter the string {i+1}: ");
            strs[i] = Console.ReadLine();

        }

        //Redisplay the entered array
        Console.WriteLine("\n The string you entered: ");
        for (int i = 0; i < strs.Length; i++)
        {
            Console.WriteLine($"strs[{i}] = {strs[i]}");
        }
        if (strs.Length > 0)
        {
            Program program = new Program();
            string commonPrefix = program.LongestCommonPrefix(strs);
            if (!string.IsNullOrEmpty(commonPrefix))
            {
                Console.WriteLine($"The longest common prefix is: {commonPrefix}");
            }
            else
            {
                Console.WriteLine("There is no common prefix among the input strings");
            }
        }
        else
        {
            Console.WriteLine("Input array is empty");
        }
    }
}
