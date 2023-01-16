// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(100,1000);
}

int CalculateEven()
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if ((array[i] % 2) == 0)
            result++;
    return result;
}

void PrintResult()
{
    Console.WriteLine($"[{String.Join(", ",array)}] -> {CalculateEven()}");
}

FillArray();
PrintResult();