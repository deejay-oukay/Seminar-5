// Задать массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
// Найти сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int[] GenerateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rnd.Next(min,max+1);
    Console.WriteLine($"[{String.Join(",",array)}]");
    return array;
}

int Sum(int[] array, bool positive = true)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (
            (positive && (array[i] > 0))
            ||
            (!positive && (array[i] < 0))
        )
            sum += array[i];
    return sum;
}

int[] array = GenerateRandomArray(12,-9,9);

Console.WriteLine($"Сумма положительных элементов равна: {Sum(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна: {Sum(array,false)}");