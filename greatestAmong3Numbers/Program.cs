partial class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap c: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("Cac so vua nhap: ");
        Console.WriteLine($"a = {a}, b = {b} , c = {c} ");
        int max = a;
        if (a < b) max = b;
        if (max < c) max = c;
        Console.WriteLine($"so lon nha la :{max}");
        //a = 1,b = 2, c = 3
        //a > b,1 > 2 => giá trị lơn nhất là b(2)
        //2 > c,2 > 3 => giá trị lớn nhất là c(3)
    }
}
