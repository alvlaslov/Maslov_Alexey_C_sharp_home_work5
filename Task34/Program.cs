// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


int count = 0;
Random random = new Random();
int size = random.Next(2, 10);
int[] array = new int[size];
FillArray(array);
PrintArray(array);
EvenNumber(array);
PrintEven(array);


void FillArray(int[] array)
    {
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    }

void PrintArray(int[] array)
    {
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    }

void EvenNumber(int[] array)
    {
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
    }

void PrintEven(int[] array)
{
    if (count > 0)
    {
        Console.WriteLine($"{count} even numbers in an array");
    }
    else
    {
    Console.WriteLine($"The even numbers are absent");
    }
}





