namespace LeetCode_88_Merge_Sorted_Array;

internal class Program
{
    // public void Merge(int[] nums1, int m, int[] nums2, int n) {
    //     for( int i = 0; i< n;i++){
    //         nums1[m+i] = nums2[i];

    //     }
    //     Array.Sort(nums1);
    // }
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] temp = new int[m + n];
        int i = 0, j = 0, k = 0;
        while (i < m && j < n)
        {
            if (nums1[i] <= nums2[j])
            {
                temp[k++] = nums1[i++];
            }
            else
            {
                temp[k++] = nums2[j++];
            }
        }
        while (i < m) temp[k++] = nums1[i++];
        while (j < n) temp[k++] = nums2[j++];
        for (int t = 0; t < m + n; t++) nums1[t] = temp[t];
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
