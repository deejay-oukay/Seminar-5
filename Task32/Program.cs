// Заменить элементы массива: положительные, на соответсвеющие отрицательные и наоборот
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = {-4,8,8,2};

void PrintArray()
{
    Console.Write($"[{String.Join(", ",array)}]");
}

void InvertArray()
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
}

PrintArray();
InvertArray();
Console.Write(" -> ");
PrintArray();

