// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Умножение матриц возможно, только если количество столбцов первой матрицы равно количеству строк второй матрицы

// примерное решение для квадратной матрицы
// C(№строки 0, №столбца 0) = A(№строки 0, №столбца 0) * B(№строки 0, №столбца 0) + A(№строки 0, №столбца 1) * B(№строки 1, №столбца 0) 
// C(0.0) = A(0,0) * B(0,0) + A(0,1) * B(1,0)
// C(0,1) = A(0,0) * B(0,1) + A(0,1) * B(1,1)
// C(1,0) = A(1,0) * B(0,0) + A(1,1) * B(1.0)
// C(1,1) = A(1.0) * B(0,1) + A(1,1) * B(1,1)

Console.WriteLine("Введите число, которое будет обозначать количетсво строк массива А и количество столбцов массива B");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое будет обозначать количетсво столбцов массива А и количество строк массива B");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[rows,columns];
int[,] matrixB = new int[columns,rows];
int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];

void GetArray (int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i,j] = new Random().Next (0, 10);
        }
    }
}

void PrintArray (int[,] array1)
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

void MatrixChange1 (int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                matrixC[i,j] = matrixC[i,j] + matrixA[i,k] * matrixB[k,j];
                Console.WriteLine($"i - {i}, j - {j}, k -  {k}, matrixA[i,k] {matrixA[i,k]} * matrixB[k,i] {matrixB[k,i]} matrixC {matrixC[i,j]}");
            }

        }
    }
}
GetArray (matrixA);
GetArray (matrixB);
PrintArray (matrixA);
PrintArray (matrixB);
MatrixChange1 (matrixC);
PrintArray (matrixC);



