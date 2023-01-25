Console.WriteLine("Задача 2: определить, присутствует ли в заданном массиве, некоторое число");
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
for (int index = 0; index < size; index++)
{
    array[index] = new Random().Next(-100, 100);
    Console.Write(array[index] + " ");
}
Console.WriteLine();
Console.WriteLine("Введите искомое число");
int number = int.Parse(Console.ReadLine()!);
int count = 0;
for (int index = 0; index < size; index++)
{
    if (number == array[index])
    {
        count = count + 1;
    }

}
if (count > 0)
{
    Console.Write("Искомое число присутствует в массиве");
}
 else 
 {
    Console.Write("Искомое число не присутствует в массиве");
 }