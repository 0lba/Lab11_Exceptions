int[] grades = [85, 42, 91, 67, 78, 55, 93, 71];
int sum = 0;
int countAbove70 = 0;
for (int i = 0; i < grades.Length; i++)
{
    int current = grades[i];
    sum += current;
    if (current > 70)
    {
        countAbove70++;
    }
}
double average = (double)sum / grades.Length;
Console.WriteLine($"Сумма: {sum}");
Console.WriteLine($"Среднее: {average:F1}");
Console.WriteLine($"Выше 70: {countAbove70}");