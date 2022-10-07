//Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num % 100;
if (num > 99 && num < 1000)
{
   result = result/10;
    Console.WriteLine("Вторая цифра введенного числа " + result);
}
else 
{
    Console.WriteLine("Ошибка! Введите трехзначное число!");
}