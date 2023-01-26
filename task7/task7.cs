Console.WriteLine("Задача 7: в указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
Console.WriteLine();
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите левый предел диапазона элементов массива ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите правый предел диапазона элементов массива ");
int max = int.Parse(Console.ReadLine()!);
double[] array = new double[size];
Console.WriteLine("Вот так выглядит массив: ");
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(min, max);
    Console.Write(array[index] + " ");
}
Console.WriteLine();
Console.WriteLine();
double maximum = array[0];
double minimum = array[0];
for (int index = 0; index < size; index++)
{
    if (array[index] < minimum)
        minimum = array[index];
    if (array[index] > maximum)
        maximum = array[index];
}
Console.WriteLine("Максимальный элемент: " + maximum + ", минимальный элемент: " + minimum);

double difference = maximum - minimum;
Console.WriteLine();

Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
