// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SumNums(int Num)
{
    int last = Num % 10;
    int sum;
    if (Num >= 1)
    {
        return sum = last + SumNums(Num / 10);
    }
    else return 0;
}





Console.Clear();

Console.Write("Insert the number: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = SumNums(num);

System.Console.WriteLine(res);


// ______________ИЛИ_______________________________


// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Sum(num));

// int Sum(int n)
// {
// if(n == 0)
// {
// return 0;
// }
// return n%10 + Sum(n/10);
// }