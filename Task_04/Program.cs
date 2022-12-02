// Написать программу возведения числа А в целую степень B
int Exponentiation (int a, int b)
{
    if (b == 0) 
    return 1;
    else
    return a * Exponentiation(a, b - 1);
}
Console.WriteLine("Enter a: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Number {a} to the extent {b} = {Exponentiation(a,b)}");