int Star(int M)
{

    for (int i = 1; i <= M; i++)
    {
        for (int m = 0; m < i; m++)
        {
            Console.Write("*");
            Console.Write(" ");
        }
        Console.WriteLine();
    }


    return M;
}

void Main()
{
    Console.Clear();
    Console.Write("Введите высоту елки: ");
    int h = int.Parse(Console.ReadLine()!);
    int M = Star(h);
}
Main();



