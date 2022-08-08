// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



Random random = new Random();
int size = random.Next(3, 10);
int[] array = new int[size];
FillArray(array);
PrintArray(array);
OddPositionSum(array);


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-5, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void OddPositionSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine($"Index odd position ({i}); The number = {array[i]}");
            sum += array[i];
        }
    }
    Console.WriteLine($"The sum of odd position numbers is {sum}");
}