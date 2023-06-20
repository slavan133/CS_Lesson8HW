// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetArray2d()
{
    int m = Prompt("Введите m:");
    int n = Prompt("Введите n:");
    int [,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i,j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine("Получен один из массивов:");
    return array;
}

int [,] MatrixNaMatrix (int[,] array, int [,] array2)
{
    int[,] newmatrix = new int[array.GetLength(0), array2.GetLength(1)];
    if (array.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить первый массив на этот массив: ");
        return array2;
    }
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array2.GetLength(0); ++j)
        {
                    for (int n = 0; n < array2.GetLength(1); ++n)
                    {
                      newmatrix[i, n] += array[i, j] * array2[j, n];  
                    }
        }               
    }        return newmatrix;
}

void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
}


int [,] array2d = GetArray2d();
PrintArray2d(array2d);
int [,] array2d2 = GetArray2d();
PrintArray2d(array2d2);
int [,] matrixnamatrix = MatrixNaMatrix(array2d,array2d2);
PrintArray2d(matrixnamatrix);
