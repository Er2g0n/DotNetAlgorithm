namespace _300_Valid_Parentheses;

internal class Program
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s)) return true; // Handle null or empty input

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new Solution();

        // Test cases
        Console.WriteLine(solution.IsValid("()")); // True
        Console.WriteLine(solution.IsValid("()[]{}")); // True
        Console.WriteLine(solution.IsValid("(]")); // False
        Console.WriteLine(solution.IsValid("([)]")); // False
        Console.WriteLine(solution.IsValid("{[]}")); // True
        Console.WriteLine(solution.IsValid("")); // True
    }
}
