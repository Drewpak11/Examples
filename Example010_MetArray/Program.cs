int[] array = {11, 22, 53, 24, 95, 18, 77, 18};//На входе значение из ячейки массива (find) на выходе номер ячейки массива (index)

int n = array.Length;//Длинна массива
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;//Если в ячейкак массива есть одинаковые значения пишем (break) и программа покажет только один из них - без (break) покажет все ячейки с одинаковым значением
    }
    //index = index + 1;
    index++;
}
