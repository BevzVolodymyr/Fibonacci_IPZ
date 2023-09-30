using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Введіть номер числа Фібоначчі: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Номер повинен бути не менше 0.");
        }
        else
        {
            long result = Fibonacci(n);
            Console.WriteLine($"Число Фібоначчі {n} = {result}");
        }
    }

    static long Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
