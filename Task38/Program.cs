// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        // хотел использовать для вещественных чисел .NextDouble(), но то, что она возвращает даже при каком-либо сочетании с результатом от .Next() мало похоже на пример результата в задаче
        // [3 7 22 2 78] -> 76
        // сделал вывод, что в описании задачи имелись ввиду натуральные числа
        // иначе везде нужно поменять int на double и либо вводить числа с клавиатуры либо "склеивать" результаты .Next() и .NextDouble() для генерации случайных чисел
        array[i] = rnd.Next(100);
}

int MaxMinusMin()
{
    int min = 0, max = 0;
    bool minfound = false, maxfound = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (!minfound || (min > array[i]))
        {
            min = array[i];
            minfound = true;
        }
        else if (!maxfound || (max < array[i]))
        {
            max = array[i];
            maxfound = true;
        }
    }
    return (max-min);
}

FillArray();

Console.WriteLine($"[{String.Join(" ",array)}] -> {MaxMinusMin()}");