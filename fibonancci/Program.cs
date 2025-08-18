using System;
using System.Text;

public class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhap so n: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("", CalFibonancci(i));
        }
        Console.WriteLine("So fibonanci cua {0} : ", n);
        static int CalFibonancci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }

            return n;
        }
    }
}