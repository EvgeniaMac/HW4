// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = num; i>0; i/=10)
{
    sum += i%10;
}
Console.WriteLine("Сумма циферок в введеном числе = " + sum);
