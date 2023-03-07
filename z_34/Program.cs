//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int A = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[A];
NumbersA(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void NumbersA(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    {
        numbers[j] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{

    for(int a = 0; a < numbers.Length; a++)
    {
        Console.Write(numbers[a] + " ");
    }
    
    Console.WriteLine();
}
