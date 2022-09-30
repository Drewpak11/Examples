/*Задача 26: Напишите программу которая принимает на вход число и выдает количество цифр в числе.
456 -> 3
78 -> 2
123456 -> 6

Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120

Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

/*Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;

while(num >= a)
{
    num /= 10;
    a++;

}
Console.WriteLine(a);*/

/*Console.WriteLine("");
int num = Convert.ToInt32(Console.ReadLine());

int d = 1;

for(int i = 1; i <= num; i++)
{
    d = d * i;
}
Console.WriteLine(d);*/

int [] array = new int[8];

for( int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]}");
}