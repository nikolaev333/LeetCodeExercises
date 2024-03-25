namespace ValidParentheses;
public static class ValidParenthesesEx
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IsValid("()[]{}")); //True
        Console.WriteLine(IsValid("()[]{]")); //False
        Console.WriteLine(IsValid("[}")); //False
    }

    public static bool IsValid(string s) {
        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
        }

        return s.Length == 0;
    }
}