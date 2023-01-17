// Задать массив. Определить, присутсвует ли заданное число в массиве
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] array = {6,7,19,345,3};

bool SearchInArray(int number)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == Math.Abs(number))
            return true;
    return false;
}

//Console.WriteLine((Array.IndexOf(array,Math.Abs(4)) > -1)?"да":"нет");
//Console.WriteLine((Array.IndexOf(array,Math.Abs(-3)) > -1)?"да":"нет");

Console.WriteLine(SearchInArray(4)?"да":"нет");
Console.WriteLine(SearchInArray(-3)?"да":"нет");