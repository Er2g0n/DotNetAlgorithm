using System.Text;

Console.OutputEncoding = Encoding.UTF8;


Console.WriteLine("Nhap so n: ");
int n = int.Parse(Console.ReadLine());
int fatorial = 1;
for (int i = 1; i <= n; i++)
{
    fatorial = fatorial * i;

}
Console.WriteLine("Giai thua bang cua {0} = {1} " ,n,fatorial );