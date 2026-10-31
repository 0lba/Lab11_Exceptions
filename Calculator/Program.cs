static int SafeParseInt(string input, int defaultValue)
{
    try
    {
        int a = int.Parse(input);
        return a;
    }
    catch (Exception)
    {
        return defaultValue;
    }
}
Console.WriteLine(SafeParseInt("42", 1));
Console.WriteLine(SafeParseInt("abc", 1));
Console.WriteLine(SafeParseInt("99999999999999", 1));