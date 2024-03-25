namespace JumpGame;

public static class JumpGame
{
    public static void Main(string[] args)
    {
        Console.WriteLine(CanJump(new[] { 2, 3, 1, 1, 4 })); //True;
        Console.WriteLine(CanJump(new[] { 3, 2, 1, 0, 4 })); //False
        Console.WriteLine(CanJump(new[] { 2, 0 })); //True
        Console.WriteLine(CanJump(new[] { 2, 0, 0 })); //True
    }

    private static bool CanJump(int[] nums)
    {
        int furthestJump = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > furthestJump)
            {
                return false;
            }

            furthestJump = Math.Max(furthestJump, i + nums[i]);
            if (furthestJump >= nums.Length - 1)
            {
                return true;
            }
        }

        return furthestJump >= nums.Length - 1;
    }
}