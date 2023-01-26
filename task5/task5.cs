Console.WriteLine("Задача 5: найти сумму чисел одномерного массива стоящих на нечетной позиции");
Console.WriteLine();
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите левый предел диапазона элементов массива ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите правый предел диапазона элементов массива ");
int max = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Console.WriteLine("Вот так выглядит массив: ");
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(min, max);
    Console.Write(array[index] + " ");
}
//Console.WriteLine();
Console.WriteLine();
int amount = 0;
for (int index = 0; index < size; index++)
{
    if (index%2 != 0)
    amount = amount + array[index];
}
Console.Write("Cумма чисел массива, стоящих на нечетной позиции: " + amount);