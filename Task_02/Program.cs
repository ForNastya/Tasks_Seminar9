// Найти сумму элементов от M до N, N и M заданы
int Sum(int n, int m)
{
    if(n == m) 
    return n;
    else 
    return n + Sum(n + 1, m);
}
Console.WriteLine(Sum(1, 10));