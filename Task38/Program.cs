//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

//[3,21 7,04 22,93 -2,71 78,24] -> 75,53

Random random = new Random();
int size = random.Next(3, 10);
double[] array = new double[size];

FillArray(array);
PrintArray(array);
Difference(array);

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100) / 10.0;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void Difference(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
        if (array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The difference between the maximum and minimum numbers is {Math.Abs(maxNumber) - Math.Abs(minNumber)}");
}