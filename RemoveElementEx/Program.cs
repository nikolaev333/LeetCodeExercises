public class RemoveElementEx
{
    public static void Main(string[] args)
    {
        // Пример 1
        int[] nums1 = {3, 2, 2, 3};
        int val1 = 3;
        int k1 = RemoveElement(nums1, val1);
        Console.WriteLine($"Example 1: k = {k1}, nums = {string.Join(",", nums1)}");

        // Пример 2
        int[] nums2 = {0, 1, 2, 2, 3, 0, 4, 2};
        int val2 = 2;
        int k2 = RemoveElement(nums2, val2);
        Console.WriteLine($"Example 2: k = {k2}, nums = {string.Join(",", nums2)}");

    }

    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}