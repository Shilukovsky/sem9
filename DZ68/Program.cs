Console.Write("Задайте первое число  ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте вротое число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

int GetAckkeranFunсtion(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return GetAckkeranFunсtion(num1 - 1, 1);
    else return GetAckkeranFunсtion(num1 - 1, GetAckkeranFunсtion(num1, num2 - 1));
}

int ackerman = GetAckkeranFunсtion(number1, number2);
Console.WriteLine($"m = {number1}, n = {number2} -> A(m,n) = {ackerman} ");