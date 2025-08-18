using System;
using System.Linq;
using System.Collections.Generic;

//class Program
//{
//    static string CalculateGrade(double input) =>
//        input >= 90 ? "A" : input >= 80 ? "B" : input >= 70 ? "C" : input >= 60 ? "D" : "F";
//    static void Main()
//    {
//        int cases = int.Parse(Console.ReadLine());
//        var summary = new Dictionary<string, int>();
//        for (int i = 1; i <= cases; i++)
//        {
//            if (double.TryParse(Console.ReadLine(), out double score) && score >= 0 && score <= 100)
//            {
//                var grade = CalculateGrade(score);
//                Console.WriteLine($"Case {i}: {grade}");
//                summary[grade] = summary.GetValueOrDefault(grade, 0) + 1;
//            }
//            else
//            {
//                Console.WriteLine($"Case {i}: Invalid input");
//                summary["Invalid"] = summary.GetValueOrDefault("Invalid", 0) + 1;
//            }
//        }
//        Console.WriteLine("Summary " + string.Join(" ", summary.Select(kv => $"{kv.Key}-{kv.Value}")));
//    }
}

class Program
{
    static string CalculateGrade(double input)
    {
        // TODO: Let's rock 'n roll here
        return "F";
    }

    static bool IsValidInput(double input)
    {
        // TODO: Validate input
        return true;
    }

    static void Main()
    {
        var cases = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cases; i++)
        {
            var input = double.Parse(Console.ReadLine());

            if (IsValidInput(input))
            {
                var grade = CalculateGrade(input);
                Console.WriteLine($"Case {i}: {grade}");
            }
            else
            {
                Console.WriteLine($"Case {i}: Invalid input");
            }

            // TODO: Count the Grade and Invalid cases
        }
    }
}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static bool IsValid(string s)
//    {
//        Stack<char> stack = new Stack<char>();
//        foreach (char c in s)
//        {
//            if ("({[<".Contains(c)) stack.Push(c);
//            else if (stack.Count == 0 || "({[<".IndexOf(stack.Pop()) != ")}]>".IndexOf(c))
//                return false;
//        }
//        return stack.Count == 0;
//    }

//    static void Main()
//    {
//        int T = int.Parse(Console.ReadLine());
//        while (T-- > 0) Console.WriteLine(IsValid(Console.ReadLine()) ? "YES" : "NO");
//    }
//}