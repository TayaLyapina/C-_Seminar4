/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/

int size = ReadInt("Введите количество элементов в массиве: ");
int [] numbers = new int [size];

void FillArray (int [] numbers)
{
    for ( int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 99);
    }
}

void PrintArray(int[] col)
{ 
    for( int pos = 0; pos < col.Length; pos++)
    {
        Console.Write($"{col[pos]} ");
    }    
}

Console.Write($"{size} -> ");
FillArray(numbers);
PrintArray(numbers);

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}