/*
Задача 58. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10  9  8  7
*/

Zadacha58();

void Zadacha58()
{
    int columns = 4;
    int rows = 4;
    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("Вывод массива");
    PrintArray(array);

    void FillArray(int[,] array)
    {
        int number = 1;
        int direction = 0;
           while(number <= array.Length){
                for(int j = 0 + direction; j < columns - direction; j++)
                {
                    array[direction, j] = number;
                    number++;
                }
                for(int j = 0 + direction; j < columns - 1 - direction; j++)
                {
                    array[j + 1, columns - 1 - direction] = number;
                    number++;
                }
                for(int j = columns - 1; j > 0 + direction; j--)
                {
                    if(direction == 1 && array[columns - 1 - direction, j - 1 - direction] != 0)
                    break;
                    array[columns - 1 - direction, j - 1 - direction] = number;
                    number++;
                }
                if(direction == 1)
                    break;
                for(int j = columns; j > 2; j--)
                {
                    array[j - 2, direction] = number;
                    number++;
                }
                direction++;
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