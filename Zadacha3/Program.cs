/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] array1 = new int[] { 1, 2, 5, 7, 19 };
Console.WriteLine($"array1 -> [{string.Join(", ", array1)}]");
int[] array2 = new int[] { 6, 1, 33 };
Console.WriteLine($"array2 -> [{string.Join(", ", array2)}]");
