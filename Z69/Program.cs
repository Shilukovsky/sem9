Console.Write("Задайте первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте вротое число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetStep(int num1, int num2)
{
    if (num2 == 0) return 1;
    return GetStep(num1, num2 - 1) * num1;
}
if (number2 >= 0)
{
    int result = GetStep (number1, number2);
    Console.WriteLine(result);
}
else Console.WriteLine("Степень должна быть натуральной");
