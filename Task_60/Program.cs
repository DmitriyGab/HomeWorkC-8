// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3d = new int[2,2,2];

void GetArray ()
{
    int num = 10;
    for (int k = 0; k < array3d.GetLength(2); k++)
    {
        for (int i = 0; i < array3d.GetLength(0); i++)
        {
            for (int j = 0; j < array3d.GetLength(1); j++)
            {
                // array3d[i,j,k] = new Random().Next(10,100);
                array3d[i,j,k] = num;
                num += 5;
            }
        }
    }
}

void PrintArray ()
{
    for (int k = 0; k < array3d.GetLength(2); k++)
    {
        for (int i = 0; i < array3d.GetLength(0); i++)
        {
            for (int j = 0; j < array3d.GetLength(1); j++)
            {
                Console.Write($"{array3d[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// void FindNum ()
// {
//     for (int k = 0; k < array3d.GetLength(2); k++)
//     {
//         for (int i = 0; i < array3d.GetLength(0); i++)
//         {
//             for (int j = 0; j < array3d.GetLength(1); j++)
//             {
//                 for (int n = 0; n < array3d.GetLength(2); n++)
//                 {
//                     for (int l = 0; l < array3d.GetLength(0); l++)
//                     {
//                         for (int m = 0; m < array3d.GetLength(1); m++)
//                         {
//                             if (array3d[i,j,k] == array3d[l,m,n] && i!=l && j!=m && k!=n)
//                             {
//                                 // i!=l && j!=m && k!=n && 
//                                 array3d[i,j,k] = new Random().Next(30,100);
//                             }
//                         }
//                     }
//                 }        
//             }
//         }
//     }
// }


GetArray();
PrintArray();
// FindNum();
// PrintArray();

// int[] arr = new int[]{1,2,3,4};

// for (int i = 0; i <arr.Length; i++)
// {
//     if (arr[i] != 1)
//     {
//         arr[i] = arr[i] + 1;
//         Console.WriteLine($"индекс {i} значение {arr[i]}");
//     }    
// }


// int[] arr = new int[]{3,3,3,4,5};

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == 3 && i != 2)
//     {
//         arr[i] = 15;
//     }
// }
// Console.WriteLine(String.Join(",", arr));