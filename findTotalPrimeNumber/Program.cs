using System;
using System.Text;

public class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhap so n: ");
        int n = int.Parse(Console.ReadLine());
        int numberOfPrime = 0;
        for (int i = 1; i <= n; i++)
        {
            if (IsPrime(i))
            {
                numberOfPrime++;
            }
        }
            Console.WriteLine("tu 1 cho den {0} co {1} so nguyen to ", n, numberOfPrime);
        Console.Read();
    }
    static bool IsPrime(int n)
    {

        int count  = 0;
        for (int i = 1;i<=n;i++)
        {
            if (n % i ==0)
            {
                count++;
            }
        }
        return count ==2; 
    }
}