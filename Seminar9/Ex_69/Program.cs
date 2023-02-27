// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int PowAB(int A, int B)
{
    int Pow = A;
    if (B >= 1) return Pow = A * PowAB(A, B - 1);
    else return Pow = 1;
}


Console.Clear();
System.Console.WriteLine(PowAB(4, 4));