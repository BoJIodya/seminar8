// Задайте двумерный массив. 
// упорядочитm по убыванию элементы каждой строки массива

void RandomArray(int[,] array) //заполнение массива рандомно
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array) //печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();


    }

}
int[,] OrderElements(int[,] array) // сортровка массива
{
    int[] StrArray = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            StrArray[j] = array[i, j]; // перевод строки массива в отдельный массив
        }

        for (int u = 0; u < StrArray.Length - 1; u++) // сортировка строчного массива
        {
            int minPos = u;

            for (int j = u + 1; j < StrArray.Length; j++)
            {
                if (StrArray[j] > StrArray[minPos]) minPos = j;
            }
            int temp = StrArray[u];
            StrArray[u] = StrArray[minPos];
            StrArray[minPos] = temp;
        }
        for (int j = 0; j < array.GetLength(1); j++) // возврат отсортированной строчки
        {
            array[i, j] = StrArray[j];
        }
    }
    return array;
}


int[,] array = new int[5, 7];
RandomArray(array);
PrintArray(array);

array = OrderElements(array);
Console.WriteLine();

PrintArray(array);