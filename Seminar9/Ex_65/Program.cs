﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void print(int M, int N)
{
    if (N < M) return;
    else
    {
        System.Console.Write(M);
        print(M + 1, N);
    }
}


Console.Clear();
print(3, 9);