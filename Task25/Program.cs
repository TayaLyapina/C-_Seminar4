/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Без использования функции Math.Pow.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int A = ReadInt("Введите число А: ");
int B = ReadInt("Введите число B: ");

int result = 1;

for( int i = 1; i <= B; i++)
{
    result*=A;
}

Console.WriteLine($"Возведение числа {A} в степень {B} равно {result}");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}