// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Start();
void Start()
{
    int rows = SetNumber("строк");
    int columns = SetNumber("колонок");
    int pages = SetNumber("массивов");
    int[,,] matrix = FillArray(rows, columns, pages);
    PrintIndex(matrix);
    Console.WriteLine();
    Console.WriteLine();
}

int SetNumber(string text = "")
{
    Console.Write($"Введите количество {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,,] FillArray(int rows, int columns, int pages)
{
    int[,,] array = new int[rows, columns, pages];
    int count = 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
                array[k, i, j] = count;
                count += 2;
            }
        }
    }
    return array;
}

void PrintIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
