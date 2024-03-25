namespace FindTheIndexOfTheFirstOccurrenceInAString;

public static class FindTheIndexOfTheFirstOccurrenceInAStringEx
{
    public static void Main(string[] args)
    {
        Console.WriteLine(StrStr("sadbutsad", "sad")); //0
        Console.WriteLine(StrStr("leetcode", "leeto")); //-1
        Console.WriteLine(StrStr("leetcode", "code")); //4
    }

    private static int StrStr(string haystack, string needle)
    {
        return haystack.IndexOf(needle, StringComparison.Ordinal);
    }
}