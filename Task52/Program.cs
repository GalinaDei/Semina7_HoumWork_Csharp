/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void ColumneMeanCalculator (int[,]matrix)
{
    Console.Write("Среднее арифметическое для каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ = summ + matrix[i,j];
        }
        double mean = summ/matrix.GetLength(0);
        if(j!=matrix.GetLength(1)-1)
        {Console.Write($"{mean}; ");}

        else {Console.Write($"{mean}.");}
    }
}
int[,]resultMatrix = CreateMatrix(5,5);
PrintMatrix (resultMatrix);
ColumneMeanCalculator (resultMatrix);
