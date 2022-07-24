/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* void Print(double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
}
int m = 3;
int n = 4;

double [,] mass = new double[m, n];

Console.WriteLine(mass.GetLength(0));
Console.WriteLine(mass.GetLength(1));

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
         mass[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
    }
    Console.WriteLine(); 
}

Print(mass);
Console.WriteLine();
Print(mass); */


/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/ 

/* void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
}
int m = 5;
int n = 7;
int[,] mass = new int[m, n];
Console.WriteLine(mass.GetLength(0));
Console.WriteLine(mass.GetLength(1));

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

Console.WriteLine("Введите строку: ");
int pos1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите столбец: ");
int pos2 = int.Parse(Console.ReadLine());

if (pos1 < 0 | pos1 > mass.GetLength(0) | pos2 < 0 | pos2 > mass.GetLength(1))
{
    Console.WriteLine("Позиции не существуют, такого числа в массиве нет");
}
else 
{
    Console.WriteLine(mass[pos1,pos2]);
}
*/

/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.
*/

void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
}
int m = 3;
int n = 4;
int[,] mass = new int[m, n];
Console.WriteLine(mass.GetLength(0));
Console.WriteLine(mass.GetLength(1));

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
      mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

double avr = 0;
double[] sum = new double[mass.GetLength(1)];

for (int i = 0; i < mass.GetLength(1); i++)
{
    for (int j = 0; j < mass.GetLength(0); j++)
   
    {
        sum[i] += mass[j,i]; 
        avr = sum[i] / mass.GetLength(0);
    }
    
Console.Write($"\t Среднее арифметическое по столбцу {i+1}: {Math.Round(avr, 2)}");
}
   

