// Задайте двухмерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// 1. Квадрат ли это? проверка
// 2. Заполнить новую матрицу

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetArray2d(int m, int n)
{
    int [,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i,j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine("Полученный массив:");
    return array;
}

int [,] NewGetArray2d(int [,] array2d, int m, int n)
{
    int [,] newArray = new int [m,n];
    for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
               if (m==n)
                {
                newArray[i,j] = array2d[j,i];
                }
                else
                {
                    Console.WriteLine("Это невозможно!");
                    return array2d;
                }
            }    
        }
    Console.WriteLine("Преобразованный массив:");
    return newArray;
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
int m = Prompt ("Введите m:");
int n = Prompt ("Введите n:");
int [,] array2d = GetArray2d(m,n);
PrintArray2d(array2d);
int [,] array2d2 = NewGetArray2d(array2d,m,n);
PrintArray2d(array2d2);

