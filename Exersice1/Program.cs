// Напишите цикл, который принимает на вход два числа (А и В) 
// и возводит число А в натуральную степень В
int GetStep(int M)
{   
    Console.Write("Enter number B: ");
    int B = int.Parse(Console.ReadLine()!);
    int C = M;
    int count = 1;
    while (count < B)
    {
        M = M * C;
        count++;
    }
    return M;
}

void Main()
{
Console.Clear();
Console.Write("Enter number A: ");
int A = int.Parse(Console.ReadLine()!);
int M = GetStep(A);
Console.WriteLine(M);
}
Main();
