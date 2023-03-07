// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечетных позициях.



int sum = 0;
Console.WriteLine("Введите массив: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] A = new int[a];
for (int i = 0; i < A.Length; i++)
{
     Console.WriteLine("Введите номер: ");
     A[i] = Convert.ToInt32(Console.ReadLine());
}
    for (int i = 0; i < A.Length; i++)
     {
        if (A[i] % 2 == 1)
        {
             sum += A[i];
        }
    }
        Console.WriteLine("Сумма всех нечетных элементов массива - {0}", sum);


