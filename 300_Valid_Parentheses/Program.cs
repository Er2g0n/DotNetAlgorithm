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



    /*
     Cấu trúc luồng xử lý:
        foreach (char c in s) {
        if (c là dấu mở) → push vào stack
        else {
            if (stack rỗng → sai) → return false
            pop stack
            nếu không khớp với dấu đóng → return false
        }
        }
        return stack.Count == 0;

     * 
             flowchart TD

        A[Start] --> B[Khởi tạo stack rỗng]
        B --> C[Duyệt từng ký tự trong chuỗi s]

        C --> D{Ký tự là dấu mở?}
        D -- Yes --> E[Push vào stack]
        E --> C

        D -- No --> F{Stack có rỗng không?}
        F -- Yes --> G[Return false ❌]

        F -- No --> H[Pop phần tử đầu stack]
        H --> I{Dấu đóng có khớp với dấu mở?}
        I -- No --> G[Return false ❌]
        I -- Yes --> C

        C -->|Duyệt hết chuỗi| J{Stack có rỗng không?}
        J -- Yes --> K[Return true ✅ Hợp lệ]
        J -- No --> G[Return false ❌]

        K --> L[End]
        G --> L

     
     */

}
