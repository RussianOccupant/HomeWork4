﻿// Напишите программу, которая задает массив из 8 элементов и выводит их на экран


void Massive(int[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] mas)
{
    int count = mas.Length;
    int position = 0;
    while (position < count - 1)
    {
        Console.Write(mas[position]); // вывод значения текущего элемента массива 
        Console.Write(", ");
        position++;
    }
    Console.Write(mas[position]);
    Console.Write(".");

}
void Main()
{
    int[] array = new int[8];
    Console.Clear();
    Massive(array);
    PrintArray(array); // print massive
}
Main();
