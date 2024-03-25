namespace SearchInsertPosition;

public static class SearchInsertPositionEx
{
    public static void Main(string[] args)
    {

        int[] numb = new[] { 1, 3, 5, 6 };

        Console.WriteLine(SearchInsert(numb, 5)); //2
        Console.WriteLine(SearchInsert(numb, 2)); //1
        Console.WriteLine(SearchInsert(numb, 7)); //4
    }

    private static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) {
                return mid;
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return left;
    }
}