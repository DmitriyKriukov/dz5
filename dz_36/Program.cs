// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int size = 4;
int[] numbers = new int[size];
FillArray(numbers);

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 100);
    }
}

int SumOddPositions(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        sum += numbers[i];    
    }
    return sum;
}

Console.WriteLine("[" + String.Join(",", numbers) + "]");
Console.WriteLine(SumOddPositions(numbers));