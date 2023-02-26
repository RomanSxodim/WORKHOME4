
/*
// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

Raise(numA, numB);

void Raise(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    result = result * a;
    Console.WriteLine("A в степени B равно: " + result);
}

*/

// Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

int Ent(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
    sum += number % 10;
    number /= 10;
    }
    return sum;
}

int numb = Ent("Введите число: ");
Console.WriteLine($"сумма всех цифр в числе равна:  {numb} = {SumNumbers (numb)}");

