// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] quadro = new int[4,4];

int i = 0;
int j = 0;
int num = 1;
void GetArray ()
{
    while (i <quadro.GetLength(0))
    {
        quadro[i,j] = num;
        num += 1;
        i++;
    }

    i = quadro.GetLength(0)-1;
    j ++; 
    while (j < quadro.GetLength(1))
    {
        quadro[i,j] = num;
        num += 1;
        j++;
    }
    
    i = quadro.GetLength(0)-2;
    j = quadro.GetLength(1)-1; 
    while (i >= 0)
    {
        quadro[i,j] = num;
        num += 1;
        i = i - 1;
    }

    i = 0;
    j = quadro.GetLength(1)-2;
    while (j > 0)
    {
        quadro[i,j] = num;
        num += 1;
        j = j - 1;
    }

    i = 1;
    j = 1;
    while (i < quadro.GetLength(0)-1)
    {
        quadro[i,j] = num;
        num += 1;
        i ++;    
    }

    i = quadro.GetLength(0)-2;
    j = quadro.GetLength(1)-2;
    while (i > 0)
    {
        quadro[i,j] = num;
        num += 1;
        i = i - 1;    
    }
}

void PrintArray ()
{
    for (int k = 0; k < quadro.GetLength(0); k++)
    {
        for (int l = 0; l < quadro.GetLength(1); l++)
        {
            Console.Write(quadro[l,k] + "  ");
        }
    Console.WriteLine();
    }
Console.WriteLine();
}

GetArray ();
PrintArray();