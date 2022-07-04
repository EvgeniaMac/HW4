// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int number = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число В:");
int exponentiation = Convert.ToInt16(Console.ReadLine());
int result = 1;
int count = 0;


while (count < exponentiation)
{
    result = result * number;
    count++;
}
Console.WriteLine($"А в степени В = " + result);