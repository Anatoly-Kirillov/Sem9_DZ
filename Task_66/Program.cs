// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbers(int M, int N)
{
    return M == N ? N : M + SumNumbers(++M, N);
}
Console.Write("Укажите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(numM, numN);
System.Console.WriteLine($"Сумма чисел от {numM} до {numN} = {sumNumbers}");