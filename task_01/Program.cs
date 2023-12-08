// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

void FillArray(char[,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (char)rand.Next(97, 123); 
        }
    }
}

void PrintArray(char[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ArrayToString(char[,] arr, string str)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            str = arr[i, j].ToString();
            Console.Write(str);
        }
    }
}

int random = new Random().Next(2,4);
int lenght = random;
char[,] array = new char[lenght, lenght];
FillArray(array);
PrintArray(array);

string str = "";
ArrayToString(array, str);
Console.WriteLine();
Console.WriteLine(str);


// Так же узнал про StringBuilder, очень отдаленно понял что за инструмент, поэтому не стал пользоваться.