// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int size = 5;
double[] numbers = new double[size];
FillArray(numbers);

void FillArray(double[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}

double DiffMaxMin(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    double diff = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
            max = numbers[i];
        if (numbers[i] < min)
            min = numbers[i];
    }
    diff = max - min;
    return diff;
}

Console.WriteLine("[" + String.Join(", ", numbers) + "]");
Console.WriteLine(DiffMaxMin(numbers));