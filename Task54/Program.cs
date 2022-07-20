/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/


Zadacha54();

void Zadacha54()
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
    Console.WriteLine("Вывод упорядоченного массива");
    ChangeDescendingElements(array);
    PrintArray(array);


    void ChangeDescendingElements(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                for (int z = 0; z < columns - 1; z++)
                {
                    if (array[i, z] > array[i, z + 1])
                    {
                        int temp = 0;
                        temp = array[i, z];
                        array[i, z] = array[i, z + 1];
                        array[i, z + 1] = temp;
                    }
                }
            }
        }
    }

    void FillArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(0, 10);
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