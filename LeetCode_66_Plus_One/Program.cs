namespace LeetCode_66_Plus_One;

internal class Program
{

        public int[] PlusOne1(int[] digits)
        {
        // duyệt từ chữ số cuối cùng
        for (int i = digits.Length - 1; i >= 0; i--)
            {
                if(digits[i] < 9)
                {
                    digits[i] = digits[i] + 1; // cộng 1 xong là xong
                    return digits;
                }
                else
                {
                    digits[i] = 0; // 9 + 1 = 10 -> ghi 0, còn 1 nhớ sang trái
                }
            }
        // nếu đến đây nghĩa là toàn 9 (ví dụ 9, 9, 9)
        int[] ans = new int[digits.Length + 1];
        ans[0] = 1; // 999 + 1 = 1000
        // các phần còn lại mặc định là 0
        return ans;

    }
    //public int[] PlusOne2(int[] digits)
    //{
    //    int carry = 1;
    //    for(int i = digits.Length - 1; i >= 0; i--)
    //    {
    //        int sum = digits [i] + carry;
    //        if(sum >= 10)
    //        {
    //            digits [i] = sum - 10;
    //            carry = 1;

    //        }else
    //        {
    //            digits [i] = sum;
    //            carry = 0;

    //        }
    //    }
    //    if(carry== 1)
    //    {
    //        int[] ans = new int[digits.Length + 1];
    //        ans[0] = 1;
    //        for (int i = 0;i< digits.Length;i++) ans [i + 1] = digits[i];
    //       return ans;
    //    }
    //    return digits;

    //}

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of elements n(>0): ");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n)||n<=0)
        {
            Console.WriteLine("Wrong format. Re-enter n (>0): ");
        }

        int[] digits = new int[n]; 
        for(int i = 0; i < n; i++) {

            Console.WriteLine($"digits[{i}](0..9)");
            int val;
            while(!int.TryParse(Console.ReadLine(), out val)|| val<0|| val > 9)
            {
                Console.WriteLine("Value must be from 0 to 9. Re-enter: ");
            }
            digits[i] = val;
        }
        Program p = new Program();
        int[] result = p.PlusOne1(digits);
        Console.Write("Result: [");
        for (int i = 0; i < result.Length; i++) {
            Console.Write(result[i]+ ", ");
                }
        Console.WriteLine("]");
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
