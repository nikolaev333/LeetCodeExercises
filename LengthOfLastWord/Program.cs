public class RemoveElementEx
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLastWord("Hello World"));
        Console.WriteLine(LengthOfLastWord(" fly me   to   the moon  "));
        Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    }

    public static int LengthOfLastWord(string s)
    {
        int start = 0;
        int end = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (!s[i].Equals(' '))
            {
                end = i;
                break;
            }
        }

        for (int j = end; j >= 0; j--)
        {
            if (s[j].Equals(' '))
            {
                start = j;
                break;
            }
        }

        return end - start;
    }
}