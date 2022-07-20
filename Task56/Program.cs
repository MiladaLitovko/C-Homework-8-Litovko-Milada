/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Zadacha56();

void Zadacha56()
{
    Random random = new Random();
    Console.WriteLine("Введите кол-во столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во строк");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("Вывод массива");
    PrintArray(array);
    int[] sumArray = FindSum(array);
    RowWithSmallestSumOfElements(sumArray);


    int[] FindSum(int[,] array)
    {
        int[] result = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for(int j = 0; j < columns; j++)
            {
                sum = sum + array[i, j];
            }
            result[i] = sum;
        }
        return result;
    }

    void RowWithSmallestSumOfElements(int[] array)
    {
        int minSum = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < minSum)
            {
                minSum = array[i];
                index = i;
            }
        }
        Console.WriteLine($"Строкa с наименьшей суммой элементов - {index + 1}");
    }
    
    

    void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(0, 11);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }


}