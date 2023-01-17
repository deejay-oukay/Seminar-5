// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат записать в новыом массиве
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {1,2,3,4,5};
//int[] array = {6,7,3,6};

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(" ",array)}]");
}

int elementsCountInNewArray = array.Length/2;

if ((array.Length % 2) != 0)
    elementsCountInNewArray++;

int[] newArray = new int[elementsCountInNewArray];

for (int i = 0; i < array.Length/2; i++)
    newArray[i] = array[i]*array[^(1+i)];

if ((array.Length % 2) != 0)
    newArray[elementsCountInNewArray-1] = array[elementsCountInNewArray-1];

PrintArray(array);
PrintArray(newArray);