// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Преобразуем двухмерный массив в одномерный и сортируем от минимального к максимальному. Считаем количества одинаковых элементов.

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
    Console.WriteLine("Полученный массив:");
    return array;
}

int [] NewArray(int [,] array2d)
{
    int [] newArray = new int [array2d.GetLength(0)*array2d.GetLength(1)];
    int ind = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
        {
          for (int j = 0; j < array2d.GetLength(1); j++)
          {
            newArray[ind] = array2d[i,j];
            ind++; // Инд плюсуются, пока не закончатся циклы сверху по j и i
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

void test (int [] array)
{
    int sluchelem = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == sluchelem)
        {
        count++;
        }
        else
        {
            Console.WriteLine($"{sluchelem} встречается в массиве {count} раз, " );
            count = 1;
            sluchelem = array [i];
        }
    }
    Console.WriteLine($"{sluchelem} встречается в массиве {count} раз " );
}


int [,] array2d = GetArray2d();
PrintArray2d(array2d);
int [] array2dtransfornation = NewArray(array2d);
Console.WriteLine(String.Join(",", array2dtransfornation));
Array.Sort(array2dtransfornation);
Console.WriteLine("Тот же массив по возрастанию:");
Console.WriteLine(String.Join(",", array2dtransfornation));
test(array2dtransfornation);
