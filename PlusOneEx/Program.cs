namespace PlusOne;

public class PlusOneEx
{
    public static void Main(string[] args)
    {
        PrintArray(PlusOne(new[] {1, 2, 3}));
        PrintArray(PlusOne(new[] {1, 2, 9}));
        PrintArray(PlusOne(new[] {9, 9, 9}));
        PrintArray(PlusOne(new[] {5}));
        PrintArray(PlusOne(new[] {1, 0, 9}));
    }

    private static int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }
        
        int[] newNumber = new int[digits.Length + 1];
        newNumber[0] = 1;
        return newNumber;
    }

    private static void PrintArray(int[] array)
    {
        Console.WriteLine(String.Join(", ", array));
    }

}