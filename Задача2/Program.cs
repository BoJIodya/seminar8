// Задайте прямоугольный двумерный массив. Найти строку с наименьшей суммой элементов. 

//при нахождении сумммы, результат вывести в виде номера строки? или вывести результат суммирования? 

// сделал вывод суммы в каждой строке, для нагляжности.
// результат выводится отдельной строкой.

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
int[] SummRowArray(int[,] array)
{
    int[] summa = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            summa[i] += array[i, j];
    }
    return summa;
}

void ArraySummAndPrintResult(int[] array) //поиск суммы и печать результата
{
    int min = array[0];
    int index = 0;
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;          // тут записывается в какой строке минимальная сумма. Отчет идет от 0
                                //Для конечного пользователя, можно поставить i + 1 
        }
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов = {min}, в строке массива {index}");
}

int[,] array = new int[5, 5];
RandomArray(array);
PrintArray(array);

int[] result = SummRowArray(array);
ArraySummAndPrintResult(result);