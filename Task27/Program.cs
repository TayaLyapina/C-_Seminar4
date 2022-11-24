/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = ReadInt("Введите число: ");

int sum = 0;
int digit = 0;
while (number > 0)
{
    digit=number%10;
    sum=sum+digit;
    number = number/10;
}
Console.WriteLine($"Сумма цифр в числе: {sum}");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}