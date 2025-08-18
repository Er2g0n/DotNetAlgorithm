static string ReversedString(string value)
{
    Stack<char> chars = new Stack<char>();
    foreach (char c in value)
    {
        chars.Push(c);
    }
    string reversed = string.Empty;
    while (chars.Count > 0)
    {
        reversed += chars.Pop();

    }

    return reversed;
}
Console.WriteLine("input string: ");
string input = Console.ReadLine();
string result = ReversedString(input);
Console.WriteLine(result);