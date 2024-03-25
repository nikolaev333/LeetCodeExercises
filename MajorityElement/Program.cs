namespace MajorityElement;
public static class MajorityElementEx
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
        Console.WriteLine("The majority element is: " + FindMajorityElement(nums));
    }

    private static int FindMajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;
  

        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
            }

            count += (nums[i] == candidate) ? 1 : -1;
        }

        return candidate;
    }
}