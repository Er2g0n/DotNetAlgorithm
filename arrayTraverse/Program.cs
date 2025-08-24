
class Program
{
    static int[] array;  // Sử dụng List để dễ dàng quản lý các thao tác
    static void Main()
    {
        Console.WriteLine("Manage Array Practice 1");
        Console.WriteLine("------------------------------");
        Console.WriteLine("Enter the number of elements in the array:");
        int length = int.Parse(Console.ReadLine());
        // Đọc độ dài mảng từ người dùng.
        array = new int[length];
        // Khởi tạo mảng với độ dài đã nhập.
        Console.WriteLine("Enter values for each element in the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            // Nhập giá trị cho từng phần tử trong mảng.
        }
        int choice;
        do
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\nSelect an action:");
            Console.WriteLine("1. Add element");
            Console.WriteLine("2. Remove element");
            Console.WriteLine("3. Edit element");
            Console.WriteLine("4. Display array");
            Console.WriteLine("5. Search element");
            Console.WriteLine("6. Count element occurrences");
            Console.WriteLine("7. Filter data");
            Console.WriteLine("8. Merge arrays");
            Console.WriteLine("9. Reverse array");
            Console.WriteLine("10. Calculate sum and average");
            Console.WriteLine("11. Find maximum value in the array");
            Console.WriteLine("12. Find minimum value in the array");
            Console.WriteLine("13. Sort Array Ascending");
            Console.WriteLine("14. Sort Array Descending");
            Console.WriteLine("15. Find Second Largest");
            Console.WriteLine("16. Reverse Array In Place");

            Console.WriteLine("0. Exit");
            Console.WriteLine("------------------------------");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    //AddElement();
                    break;
               
                case 0:
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        } while (choice != 0);
    }


}