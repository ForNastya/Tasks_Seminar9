// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
string ProgramN(int numberA, int numberB, int count)
{
    if(count!=0)
    {
        --count;
        int sum = numberA + numberB;
        return $"{sum} " + ProgramN(numberB, sum, count);
    }
    else
    return String.Empty;
}

Console.WriteLine("Enter a: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter b: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter n: ");
int count = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"{numberA} " + $"{numberB} " + ProgramN(numberA, numberB, count));