// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void Work(int N)
{

    if (N == 0) return;
    else if (N > 0)
    {
        Work(N - 1);
        System.Console.Write(N + " ");
    }
    else return;


}

Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Work(N);
