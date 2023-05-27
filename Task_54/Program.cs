// // Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array1 = new int[rows, columns];

void GetArray ()
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i,j] = new Random().Next (0, 100);
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

void ChangeArray ()
{
    int temp = 0;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 1; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                if (array1[i,j] > array1[i,k])
                {
                    temp = array1[i,k];
                    array1[i,k] = array1[i,j];
                    array1[i,j] = temp;
                }
            }
        }
    }
}

GetArray ();
PrintArray ();
ChangeArray ();
PrintArray ();


//  Боль, пока я пытался решить эту задачу

// for (int i = 0; i < array1.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         array1[i,j] = new Random().Next(0,10);
//         Console.Write(array1[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// for (int i = 0; i < array1.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1)-1; j++)
//     {
//         if (array1[i,j] < array1[i,j+1])
//         {
//             // int temp = array1[i,j+1];
//             // array1[i,j+1] = array1[i,j];
//             // array1[i,j] = temp;
//             // Console.WriteLine(array1[i,j]+  " array1[i,j]");
//             // Console.WriteLine(array1[i,j+1]+  " array1[i,j+1]");
//         }    
//     }
// }

// Console.WriteLine("_____________");

// for (int i = 0; i < array1.GetLength(0); i++)
// {
//     for (int j = 0; j < array1.GetLength(1); j++)
//     {
//         Console.Write(array1[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());



// for (int j = 0; j < array.Length; j++)
// {
//     array[j] = new Random().Next(1,10);
//     Console.Write(array[j]+ ", ");
// }

// int i = 0;
// int max = array[i];
// while (i < array.Length-1)
// {
//     if (array[i] < array[i+1])
//     {
//         int temp = array[i+1];
//         array[i+1] = array[i];
//         array[i] = temp;
//     }
//     i++;
// }

// Console.WriteLine("________________");

// for (int j = 0; j < array.Length; j++)
// {
//     Console.Write(array[j]+ ", ");
// }


// int[] arr = new int[]{2,5,7,1,9};
// Console.WriteLine(String.Join(", ", arr));

// int i = 0;
// int temp = 0;
// while (i < arr.Length-1)
// {
//     temp = arr[i+1];
//     arr[i+1] = arr[i];
//     arr[i] = temp;
//     i++;
//     Console.WriteLine(arr[i] +" , " + arr[i+1] + " , " + i );
// }

// Console.WriteLine("_________________");
// Console.WriteLine(String.Join(", ", arr));


// Алгоритм упорядочивания массива, который работает!
// int[] arr = new int[]{4,3,5,2,1};
// // int i = 0;
// // int j = 1;
// int min = arr[0];
// int size = 5;
// int temp = 0;

// Console.WriteLine(String.Join(", ", arr));

// // while (i < size-1)
// // {
// for (int i = 1; i < size; i++)
// {
//     for (int j = 0; j < size-1; j++)
//     {
//         if (arr[i] > arr[j])
//         {
//             temp = arr[j];
//             arr[j] = arr[i];
//             arr[i] = temp;
//         }
//     }
// }

// Console.WriteLine(String.Join(", ", arr));