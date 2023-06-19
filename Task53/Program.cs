// Задайте двухмерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetArray2d()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
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

int [,] GetArray2d2(int [,] array2d)
{
    int temp = 0;
    int[,] copy = array2d.Clone() as int[,];
        for (int j = 0; j < copy.GetLength(1); j++)
        {
                temp = array2d [0,j];
                copy [0,j] = copy [copy.GetLength(0)-1,j];
                copy[copy.GetLength(0)-1,j]= temp;    
        }
    Console.WriteLine("Преобразованный массив:");
    return copy;
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
int [,] array2d2 = GetArray2d2(array2d);
PrintArray2d(array2d2);

