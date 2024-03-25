namespace LengthOfLastWord;

public static class LengthOfLastWordEx
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLastWord("Hello World")); // 5
        Console.WriteLine(LengthOfLastWord(" fly me   to   the moon  ")); //4
        Console.WriteLine(LengthOfLastWord("luffy is still joyboy")); //6
        Console.WriteLine(LengthOfLastWord("a")); //1
        Console.WriteLine(LengthOfLastWord("day")); //3
    }
    
    public static int LengthOfLastWord(String s) {
        s = s.Trim();
        String last = s.Substring(s.LastIndexOf(' ')+1);
        int n = last.Length;
        return n;
    }
 
    /*private static int LengthOfLastWord(string s)
    {
        int firstLetter = 0;
        int lastLetter = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (!s[i].Equals(' '))
            {
                lastLetter = i;
                break;
            }
        }

        for (int j = lastLetter; j >= 0; j--)
        {
            if (s[j].Equals(' '))
            {
                firstLetter = j + 1;
                break;
            }
        }
        return lastLetter - firstLetter + 1;
    }*/
}