Console.WriteLine("Задача 4: В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");
Console.WriteLine();
Console.WriteLine("Введите левый предел диапазона элементов массива ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите правый предел диапазона элементов массива ");
int max = int.Parse(Console.ReadLine()!);
int[] array = new int[123];
Console.WriteLine("Вот так выглядит массив: ");
for (int index = 0; index < 123; index++)
{
    array[index] = new Random().Next(min, max);
    Console.Write(array[index] + " ");
}
Console.WriteLine();
Console.WriteLine();
int amount = 0;
for (int index = 0; index < 123; index++)
{
    if (array[index] >= 10 && array[index] <= 99)
    amount = amount + 1;
}
Console.Write("Количество элементов массива из отрезка [10,99] -  " + amount);