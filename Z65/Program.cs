Console.Write("Задайте первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте вротое число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num1, int num2)
{
    if(num1 == num2)
    {
        Console.Write($"{num1} ");
        return;
    }
    if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumber(num1 - 1, num2);
    }
    else
    {
        NaturalNumber(num2 - 1, num1);
        Console.Write($"{num2} ");   
    }
}
NaturalNumber(number1, number2);

