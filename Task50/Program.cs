/* Задача 50. Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int [,] CreateMatrix (int m, int n)
{
  int [,] matrix = new int [m,n];
  Random rnd = new Random();
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
        matrix[i,j]=rnd.Next(1,9);
    }
  }
  return matrix;
}
void PrintMatrix (int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        Console.Write($"{matrix[i,j]} ");        
       }
       Console.WriteLine(); 
    }
}

void ElementSearch (int[,]matrix, int m, int n)
{
    if(m>=matrix.GetLength(0) | n>=matrix.GetLength(1))
    {Console.WriteLine("Такого числа нет");}
    else {Console.WriteLine($"{matrix[m,n]}");}
}
int[,]resultMatrix = CreateMatrix(7,7);
PrintMatrix(resultMatrix);
ElementSearch(resultMatrix, 7, 7);
