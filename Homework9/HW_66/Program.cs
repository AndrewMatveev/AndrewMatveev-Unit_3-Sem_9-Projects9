// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBtwMN(int M, int N)
{
    int CurNum = N;
    int Sum = 0;
    if (M <= CurNum && CurNum <= N)
    {
        return Sum = CurNum + SumBtwMN(M, N - 1);
    }
    else return 0;
}


Console.Clear();
System.Console.Write("Enter num M (start): ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num N (finish): ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum = SumBtwMN(M, N);
System.Console.Write($"Sum of nubmers between {M} and {N} equal {Sum}");