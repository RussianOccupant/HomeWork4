// напишите функцию и запустите ее, которая принимает на вход число 
// и выдаёт сумму цифр в нём
int GetSum(int M)
{   int sum = 0;
    while (M != 0)
    {
        int digit = M % 10;
        sum = sum + digit;
        M = M / 10;
    }
    return sum;
}

void Main()
{
    Console.Clear();
    Console.Write("Enter number: ");
    int n = int.Parse(Console.ReadLine()!);
    int sum = GetSum(n);
    Console.WriteLine($"Сумма цифр в числе {n} равна {sum}");
}
Main();