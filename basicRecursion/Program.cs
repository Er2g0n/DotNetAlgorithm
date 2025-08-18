
class Program
{
    static int Sum(int n)
    {
        if (n == 1)
        {
            return 1;   

        }
        return n + Sum(n-1);
    }

    static void Main()
    {
        Console.WriteLine("Nhap so: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(Sum(input));
    }
}
