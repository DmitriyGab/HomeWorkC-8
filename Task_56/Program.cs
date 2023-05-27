// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array1 = new int[rows, columns];

int minSum = int.MaxValue;
int minRow = 0;

void GetArray ()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i,j] = new Random().Next (0, 10);
        }
    }
}

void PrintArray ()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write(array1[i,j] + " ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

void minSumArray ()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            sum += array1[i,j];
        }
        Console.WriteLine($"Сумма элементов строки №{i+1}: {sum}");

        if (minSum > sum)
        {
            minSum = sum;
            minRow = i;
        }
    }

}

GetArray ();
PrintArray ();
minSumArray ();
Console.WriteLine($"Строка массива с наименьшей суммной элементов № {minRow + 1}");