/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/

/*
void FillArr(int[] array)// Метод fill() заполняет все элементы массива.
{
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(-9, 10);
        index++;
    }
}


void PrintArr(int[] Narray)
{
    int count = Narray.Length;
    int pos = 0;
    while(pos < count)
    {
        Console.Write($"{Narray[pos]} ");
        pos++;
    }
}

void Summ(int[] array)
{
    int count = 0;
    int SumMin = 0;
    int SumPlus = 0;
    while(count < array.Length)
    {
        if(array[count] < 0)
        {
            SumMin += array[count];
            count++;
        }
        else
        {
            SumPlus += array[count];
            count++;
        }
        
    }
    Console.WriteLine($"Сумма отрицательных элеменнтов массива = {SumMin}");
    Console.WriteLine($"Сумма положительных элеменнтов массива = {SumPlus}");
}
int [] arr = new int[12];
FillArr(arr);
PrintArr(arr);
Summ(arr);
*/

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/*
void FillArr(int[] array)
{
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(-9, 10);
        index++;
    }
}


void PrintArr(int[] Narray)
{
    int count = Narray.Length;
    int pos = 0;
    while(pos < count)
    {
        Console.Write($"{Narray[pos]} ");
        pos++;
    }
}

void PlusMin(int[] array2)
{
    int count = 0;
    while(count < array2.Length)
    {
        array2[count] =- array2[count];
        count++;
        
    }
}
int [] arr = new int[4];
FillArr(arr);
PrintArr(arr);
PlusMin(arr);
Console.WriteLine();
PrintArr(arr);
*/

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/

/*
void FillArr(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0, 4);
        index++;
    }
}


void PrintArr(int[] Array1)
{
    int count = Array1.Length;
    int pos = 0;
    while(pos < count)
    {
        Console.Write($"{Array1[pos]} ");
        pos++;
    }
}

void Search(int[] Array2, int num)
{
    int count = 0;
    int Real = 0;
    while(count < Array2.Length)
    {
        if(Array2[count] == num) //!= знак не равен
        {
            Real = 1;
            count++;
        }
        else
        {
            count++;
        }
    }
    if(Real == 1)
    {
        Console.WriteLine("Такое число есть в массиве");
    }
    else
    {
        Console.WriteLine("Такого числа нет");
    }
}

int[] Arr = new int[10];
FillArr(Arr);
Console.WriteLine("Введите число для поиска: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintArr(Arr);
Search(Arr, N);
*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/









