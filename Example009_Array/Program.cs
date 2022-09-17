int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}// Ячейки       0   1   2   3  4   5   6   7   8
int [] array = {18, 12, 33, 24, 5, 61, 75, 81, 19};
//array[0] = 12; // Обрашение к масиву и записать значение

//Console.WriteLine(array[0]);// Обрашение к масиву и получение значения элемента по указанному индексу

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);// Так пишеться в одну строку
Console.WriteLine(result);




