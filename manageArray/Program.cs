
using System.Text;

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
                    AddElement();
                    break;
                case 2:
                    DeleteElement();
                    break;
                case 3:
                    EditElement();
                    break;
                case 4:
                    DisplayArray();
                    break;
                case 5:
                    SearchElement();
                    break;
                case 6:
                    CountElementOccurrences();
                    break;
                case 7:
                    FilterArray();
                    break;
                case 8:
                    MergeArray();
                    break;
                case 9:
                    ReverseArray();
                    break;
                case 10:
                    SumAndAverage();
                    break;
                case 11:
                    FindMaxValue();
                    break;
                case 12:
                    FindMinValue();
                    break;
                case 13:
                    SortArrayAscending();
                    break;
                case 14:
                    SortArrayDesceding();
                    break;
                case 15:
                    FindSecondLargest();
                    break;
                case 16:
                    ReverseArrayInPlace();
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

    static void AddElement()
    {
        Console.WriteLine("Enter the new element value:");
        // Đọc giá trị nhập từ bàn phím, chuyển đổi nó từ chuỗi sang số nguyên

        int newElement = int.Parse(Console.ReadLine());
        // Tạo một mảng mới có kích thước lớn hơn mảng cũ một phần tử
        int[] newArray = new int[array.Length + 1];
        // Duyệt qua mảng cũ, sao chép từng phần tử của mảng cũ sang mảng mới
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }

        // Thêm phần tử mới vào cuối mảng mới, đặt vào vị trí cuối cùng của mảng
        newArray[array.Length] = newElement;

        // Gán mảng mới này vào biến mảng cũ, cập nhật mảng cũ để nó bao gồm cả phần tử mới thêm vào
        array = newArray;

        Console.WriteLine("Element added.");
    }
    static void DeleteElement()
    {
        Console.WriteLine("Enter the index of the element to remove: ");
        int index = int.Parse(Console.ReadLine());

        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }
        int[] newArray = new int[array.Length - 1];
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                newArray[j++] = array[i];
            }

        }
        array = newArray;
        Console.WriteLine("Elemant removed.");
    }
    static void EditElement()
    {
        Console.WriteLine("Enter the index of the element");
        int index = int.Parse(Console.ReadLine());
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Invalid index");
            return;
        }
        Console.WriteLine("Enter the new value: ");
        array[index] = int.Parse(Console.ReadLine());
        Console.WriteLine("Element updated.");
    }
    static void DisplayArray()
    {
        Console.WriteLine("Array element:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
    static void SearchElement()
    {
        Console.WriteLine("Enter the value to search for:");
        int value = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                Console.WriteLine($"Element found at index: {i}");
                found = true;
                break;
            }
        }
        if (!found) Console.WriteLine("Element not found in the array");
    }
    static void CountElementOccurrences()
    {
        Console.WriteLine("Enter the value to count:");
        int value = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] == value))
            {
                count++;
            }

        }
        Console.WriteLine($"The element{value} appears {count} times in the array");
    }
    static void FilterArray()
    {
        Console.WriteLine("Enter the threshold value to filter element greater than it: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Filtered elements:");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > value)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
    static void MergeArray()
    {
        Console.WriteLine("Enter the number of elements in the array to merge:");
        int lenth = int.Parse(Console.ReadLine());
        int[] newArray = new int[array.Length + lenth];
        int i = 0;
        for (; i < array.Length; i++)  // Duyệt qua mảng hiện tại
        {
            newArray[i] = array[i];
        }
        Console.WriteLine("Enter values for the new elements:");
        for (int j = 0; j < newArray.Length; j++, i++)
        {
            newArray[i] = int.Parse(Console.ReadLine());

        }
        array = newArray;
        Console.WriteLine("Arrays have been merged.");
    }
    static void ReverseArray()
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
        Console.WriteLine("Array has been reversed.");

    }
    static void SumAndAverage()
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double average = (double)sum / array.Length;
        Console.WriteLine($"Total sum is: {sum}");
        Console.WriteLine($"Average is: {average}");
    }
    static void FindMaxValue()
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The array is empty.");
            return;
        }
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine("The maximum value in the array is: " + max);

    }
    static void FindMinValue()
    {
        if (array.Length == 0)
        {
            Console.WriteLine("The array is empty");
            return;
        }
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) { min = array[i]; }
        }
        Console.WriteLine("The minimum value in the array is: " + min);

    }
    static void SortArrayAscending()
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Array sorted in ascending order.");
    }
    static void SortArrayDesceding()
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Array sorted in descending order.");

    }
    static void FindSecondLargest()
    {
        if (array.Length < 2)
        {
            Console.WriteLine("Array does not have enough elements");
            return;
        }
        int first = int.MinValue, second = int.MaxValue;
        foreach (int value in array)
        {
            if (value > first)
            {
                second = first;
                first = value;
            }
            else if (value > second && value != first)
            {
                second = value;
            }
        }
        if (second == int.MinValue)
        {
            Console.WriteLine("No Second largest element.");
        }
        else
        {
            Console.WriteLine("Second largest element is: " + second);
        }
    }
    static void ReverseArrayInPlace()
    {
        int start = 0;
        int end = array.Length - 1;
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end--;
        }
        Console.WriteLine("Array has been reversed in place");
    }
}