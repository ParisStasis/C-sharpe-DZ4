// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("ВВедите число А ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int x =A;
for (int i = 1; i < B; i++)
{
    x = x*A;
}
Console.WriteLine(" число А в натуральной степени числа В равно: " + x);