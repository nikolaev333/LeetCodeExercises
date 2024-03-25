namespace PalindromeNumber;

public static class IsPalindromeEx
{
    public static void Main(string[] args)
    {
        bool result = IsPalindrome1(121);
        bool result1 = IsPalindrome1(-121);
        bool result2 = IsPalindrome1(123);
        
        Console.WriteLine(result); //True
        Console.WriteLine(result1); //False
        Console.WriteLine(result2); //False
    }

    public static bool IsPalindrome1(int x)
    {
        if (x < 0) return false;

        int temp = x;
        int reverse = 0;

        while (temp != 0)
        {
            int digit = temp % 10;
            reverse = reverse * 10 + digit;
            temp /= 10;
        }

        return reverse == x;
    }
}