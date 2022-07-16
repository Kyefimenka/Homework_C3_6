// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* Console.WriteLine("Input count of numbers");
int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];
int count = 0;
Console.WriteLine("Input numbers");
for (int i = 0; i < M; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i] > 0)
    {
        count++;
    }
    //count = array[i] > 0 ? count + 1 : count;
}
Console.WriteLine($"Count of positive numbers = {count}"); */

Console.WriteLine("Input numbers separated by spase");
string rawNumbers = Console.ReadLine();
if (rawNumbers.Trim() == string.Empty)
{
    Console.WriteLine("You didn't input anything");
    return;
}
int[] array = Array.ConvertAll(rawNumbers.Split(" "), int.Parse);
int count = 0;
//for (int i = 0; i < array.Length; i++)
foreach (int number in array)
{ 
    count = number > 0 ? count + 1 : count; 
}
Console.WriteLine($"Count of positive numbers = {count}");