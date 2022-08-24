Console.Write("Задайте первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте вротое число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 < num2) 
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    return SumOfNumber(num1 - 1, num2) + num1;
 
}

int result = SumOfNumber(number1, number2);
Console.WriteLine($" M = {number1}; N = {number2} -> {result} ");
