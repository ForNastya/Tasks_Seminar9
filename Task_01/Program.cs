// Показать натуральные числа от M до N, N и M заданы
string Numbers (int n, int m)
{
    if (n <= m)
    return Numbers(n + 1, m) + $"{n}";
    else
    {
        return String.Empty;
    }
}
Console.WriteLine(Numbers(1, 10));