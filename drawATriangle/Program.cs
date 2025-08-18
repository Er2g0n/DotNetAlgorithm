using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu cao cua tam gia : ");
        int n = int.Parse(Console.ReadLine());
        //Buoc 1
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine("/");
        //}
        //Buoc 2
        //for (int i = 1; i <= n; i++)
        //{

        //    int x = i * 2 - 1;
        //    for (int j = 1; j <= x; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine("/");
        //}
        //Buoc 3
        //for (int i = 1; i <= n; i++)
        //{
        //    for(int k = n; k> i;k--)
        //    {
        //        Console.Write("-");
        //    }
        //    int x = i * 2 - 1;
        //    for (int j = 1; j <= x; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine("/");
        //}



        //Buoc 4
        //----*      => i =1
        //---* *     => j = 1
        //--*   *    
        //-*     *   => j = x
        //*********  => i = n

        for (int i = 1; i <= n; i++)
        {
            for (int k = n; k > i; k--)
            {
                Console.Write("-");
            }
            int x = i * 2 - 1;
            for (int j = 1; j <= x; j++)
            {
                if(i == 1 || i == n || j == 1 || j == x)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" "); //lam rong?
                }
            }
            Console.WriteLine("/");
        }
    }
}