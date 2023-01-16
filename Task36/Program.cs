// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(-99,100);
}

int CalculateOddElements()
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
        result += array[i];
    return result;
}

void PrintResult()
{
    Console.WriteLine($"[{String.Join(", ",array)}] -> {CalculateOddElements()}");
}

FillArray();
PrintResult();