Console.WriteLine("Задача 6: найти произведение пар чисел в одномерном массиве.");
Console.WriteLine();
Console.WriteLine("Введите количество элементов массива (чётное)");
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
Console.WriteLine();
Console.WriteLine();
int count = 1; // для индексации результатов произведений пар
int size2 = size/2; // "середина" массива
int size3 = size-1; // для определения пары с "хвоста" массива
int result_count = 1; // результат произведения пары
Console.Write("Произведения пар чисел массива: ");
for (int index = 0; index < size2; index++)
{ 
         result_count = array[index] * array[size3];
         Console.Write(result_count + " ");
         size3 = size3 - 1;
         count = count +1;
}

