// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;
}

Console.Clear();
System.Console.Write("Enter num m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter num n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Res = Akkerman(m, n);
System.Console.Write($"Result: {Res}");