Console.WriteLine("Задача 3: задать массив, заполнить случайными положительными трёхзначными числами; показать количество нечетных/четных чисел");
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(100, 999);
    Console.Write(array[index] + " ");
}
Console.WriteLine();
int count1 = 0;//счётчик нечётных чисел
int count2 = 0;//счётчик чётных чисел
for (int index = 0; index < size; index++)
{
    if (array[index]%2 != 0)
    count1 = count1 + 1;
    else
    count2 = count2 + 1;
}
Console.WriteLine();
Console.WriteLine("Количество нечётных чисел в массиве: " + count1);
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве: " + count2);


  