namespace Bai_05_TITV_BinarySearch;

internal class Program
{


    /*
        " Yêu cầu tương tự như tìm kiếm nhảy

        " Ý tưởng:
        " NHỊ PHÂN = CHIA ĐÔI

        " 1. Tìm giá trị phần tử nằm giữa dãy, gọi là X

        " 2. Nếu X == K thì X là kết quả và thông báo chỉ số

        3. Có 2 tình huống:
        " Nếu X < K=> Tìm kiếm ở nửa sau dãy số

        " Nếu X> K=> Tìm kiếm ở nữa đầu dãy số

        " 4. Lặp lại các bước cho đến khi tìm thấy, hoặc đến khi khu vực tìm kiếm là rỗng (-1)

    ----------------------------------------------
                Input dãy A, K; Output: vị trí của K hoặc -1
            Mã giả:
            BinarySearch(A, K)

            left =1, right = n
    
            while left <= right
            
    mid = (left+right)/2 // lay phan nguyen
    
    if a[mid] == K
    
    return mid
    
    else if a[mid]<k
    
    left = mid + 1

            Xem sau Chia sẻ

            else

            right = mid - 1

            return -1
     */

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
