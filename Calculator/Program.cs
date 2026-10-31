using System.Runtime.ConstrainedExecution;

// static int SafeParseInt(string input, int defaultValue)
// {
//     try
//     {
//         int a = int.Parse(input);
//         return a;
//     }
//     catch (Exception)
//     {
//         return defaultValue;
//     }
// }
void DemoCustomException()
{
    int a = -5;
    if (a < 0)
    {
        throw new ArgumentException("Возраст не может быть отрицательным");
    }
    else
    {
        Console.WriteLine("Все верно");
    }
}
// Console.WriteLine(SafeParseInt("42", 1));
// Console.WriteLine(SafeParseInt("abc", 1));
// Console.WriteLine(SafeParseInt("99999999999999", 1));
DemoCustomException();