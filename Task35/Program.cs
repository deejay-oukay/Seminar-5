// Задать одномерный массив из 123 случайных чисел.
// Найти количество элементов массива, значения которых лежат в отрезке [10,99]
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 1
// [10, 11, 12, 13, 14] -> 5

int[] GenerateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rnd.Next(min,max+1);
    Console.Write($"[{String.Join(",",array)}]");
    return array;
}

int Search(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if ((array[i] >= min) && (array[i] <= max))
            count++;
    return count;
}

Console.WriteLine(" -> "+Search(GenerateRandomArray(123,0,200),10,99));