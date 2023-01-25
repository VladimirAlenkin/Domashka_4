Console.WriteLine("Задача 1: задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");
int[] array = new int[8];
for (int index = 0; index < 8; index++)
{
    array[index] = new Random().Next(1, 100);
    if (array[index]%2 > 0)
    {
        array[index] = 1;
    }
    else
    {
        array[index] = 0;
    }

    Console.Write(array[index] + " ");
}
