using System.Runtime.InteropServices;

namespace Bai_06_TITV_InsertionSort;



/*


    " Cho trước dãy số (hoặc dãy các phần tử có thể so sánh được, ví
    dụ dãy sâu các ký tự): a1, a2, a3, ... an

    "Cần sắp xếp dãy trên bằng phép toán so sánh để đạt được một
    dãy moi có gia trị tang dần: a1 <= a2 <= a3 <= ... <= an

    Các thuật toán sắp xếp theo yêu cầu trên được gọi chung là sắp
    xếp bằng so sánh
 

1. Thuậtt toán sắp xếp chèn (Insertion sort)
Có 2 cách:
Cách 1: vừa di chuyển, vừa đổi chỗ 2 phần tử

InsertionSort(A,n)

for i = 2 to n
    j = i
    while j>1 and aj <= aj-1
    đổi chổ aj, aj-1
    j = j - 1 

Example : 5 2 6 7 3

i = 1 -> n - 1

i = 1
    j = i = 1       a[j] = 2
    w1: a[j] <= a[j] = 2
    2 5 6 7 3

i = 2
    j = i = 2
    2 5 6 7 3
 
i = 3
    j = i = 3       a[j] = 7
    2 5 6 7 3

i = 4 
    j = i = 4       a[j] = 3
    j = 4 -> 2 5 6 3 7

    j = 3 -> 2 5 3 6 7
    
    j = 2 -> 2 3 5 6 7
    
    j = 1 -> 2 3 5 6 7 


 */

internal class Program
{
    static int insertionSort(int[] a, int n)
    {
        for (int i = 1; i < n; i++)
        {
            int key = a[i];

            int j = i;
            while (j > 0 && a[j] > key) {
                int temp = a[j];
                a[j] = a[j-1];
                a[j-1] = temp;
                j--;
        }
        for i = 2 
            key = 
    }
    static void Main(string[] args)
    {
        int[] a= new int[100];

        Console.WriteLine("Hello, World!");
        insertionSort(0, 0);
        Console.WriteLine();

    }
}
