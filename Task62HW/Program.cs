// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int [,] SpiralArray4x4()
{
int n = 4;
int[,] spiraleMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiraleMatrix.GetLength(0) * spiraleMatrix.GetLength(1))
{
  spiraleMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < 3)
    j++;
  else if (i < j && i + j >= 3)
    i++;
  else if (i >= j && i + j > 3)
    j--;
  else
    i--;
}
return spiraleMatrix;
}

void PrintArraySpiral(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (array2d [i,j] < 10)
            {
              Console.Write($" {array2d[i,j]} ");  
            } 
            else
            {
              Console.Write($"{array2d[i,j]} ");  
            }
        }
        Console.WriteLine();
    }
}

int [,] arrayspiral = SpiralArray4x4();
Console.WriteLine("Спиральный массив 4 на 4:");
PrintArraySpiral(arrayspiral);
