// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int size = 4;
int[] numbers = new int[size];
FillArray(numbers);

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

int EvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        count += 1;    
    }
    return count;
}

Console.WriteLine("[" + String.Join(",", numbers) + "]");
Console.WriteLine(EvenNumbers(numbers));
