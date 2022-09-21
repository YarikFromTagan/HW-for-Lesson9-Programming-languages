/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет
все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void PrintNumber(int m, int n)
{
  if (n > m) PrintNumber(m, n-1);
  else  if (m > n) PrintNumber(m, n+1);
  
  Console.Write(n + " ");
}


Console.Clear();
Console.WriteLine($"Для вывода всех натуральных чисел в промежутке от M до N");
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumber(m, n);










