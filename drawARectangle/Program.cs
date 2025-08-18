using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu rong x: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("nhap chieu cao y: ");
        int y = int.Parse(Console.ReadLine());

        for (int i = 1; i <= y; i++)
        {
            for (int j = 1; j <= x; j++)
            {
                if (i == 1 || i == y || j == 1 || j == x)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine("");
        }

    }
}