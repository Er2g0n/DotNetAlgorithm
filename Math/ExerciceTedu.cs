using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Giải phương trình bậc nhất ax + b = 0. Với a, b nhập từ bàn phím

Console.WriteLine("Nhập số a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhập số b: ");
int b = int.Parse(Console.ReadLine());

if (a != b)
{
    Console.WriteLine("Phương trình có nghiệm x=-b/a= {0}", (-b / a));
}
else
{
    if (b != a)
    {

        Console.WriteLine("Phương trình có vô số nghiệm");

    }
    else
    {
        Console.WriteLine("Phương trình vô nghiệm");
    }
}