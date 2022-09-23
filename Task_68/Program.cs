// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
long Ackermann(long m, long n)
{
    if (m > 0 & n > 0) 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else
    {
        if (m >= 0 & n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return n + 1;
        }
    }
}
System.Console.Write("Укажите число m: ");
long numberM = long.Parse(Console.ReadLine());
System.Console.Write("Укажите число n: ");
long numberN = long.Parse(Console.ReadLine());
long numberAckermann = Ackermann(numberM, numberN);
Console.WriteLine($"A(m,n) = {numberAckermann}");