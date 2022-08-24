Console.Write("Задайте число ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSumOfNumbers(int num)
{
    int sum = num % 10;
    if (num >= 1) 
        sum += GetSumOfNumbers(num / 10)
    return sum;
}

int result = GetSumOfNumbers(number);
Console.WriteLine($"Сумма цифр равна {result} ")
