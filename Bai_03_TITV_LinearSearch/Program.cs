

namespace Bai_03_TITV_LinearSearch;




/*
       " Bài toán: cho trước dãy a1, a2, ... an và giá trị K. Cần tìm chỉ số I
       sao cho ai = K, nếu không tìm thấy thì trả về - 1.

       " Ý tưởng:
       " Lần lượt kiểm tra từng phần tử, nếu đến cuối dãy vẫn không tìm thấy
       thì thông báo kết quả là -1.
    */

public class Program
{
    //static int LinearSearch(int[] arr ,int input)
    //{
    //    for (int i = 0; i < arr.Length ; i++)
    //    {
    //        if (arr[i] == input)
    //        {
    //            return i;
    //        }

    //    }
    //    return -1;
    //}



    //static void Main()
    //{
    //    //Bước 1: Tạo mảng và nhập giá trị
    //    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //    Console.WriteLine("Nhap so: ");
    //    int input = int.Parse(Console.ReadLine());

    //    LinearSearch(array, input);

    //    int result = LinearSearch(array, input);
    //    if (result == -1)
    //    {
    //        Console.WriteLine("Khong tim thay so {0} trong mang", input);
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Gia tri {input} o vi tri {result}");

    //    }
    //}




    /*
        Cho 2 input sau, array 11 22 33 44
           Input là số 1
            Hãy tìm tất cả các số của mảng và in ra vị trí của số đó


        dùng vòng lặp for để duyệt mảng
        để lấy từng phần tử trong mảng để so sánh với input của mình dùng ==
        tạo một mảng để lưu giá trị "vị trí" của số cần tìm
        nếu có: thì lấy ra được thì nhét nó vào mảng mới tạo
        nếu ko có: báo ko có 

        
    */
    static int[] SearchPosition(int[] arr, int input)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            count++;
        }
        int [] result = new int[count];
        int index = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == input)
            {
                result[index] = i;
                index++;
            }
        }
        return result; 
            
            }
    static void Main()
    {
        //Bước 1: Tạo mảng và nhập giá trị
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Nhap so: ");
        int input = int.Parse(Console.ReadLine());

        int[] result = SearchPosition(array, input);

        if (result.Length == 0)
        {
            Console.WriteLine("Khong tim thay so {0} trong mang", input);
        }
        else
        {
            Console.Write($"Gia tri {input} xuat hien o vi tri: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]+ " ");
            }
            Console.WriteLine();

        }
    }
}
