using System;
class Program
{
    static void Main()
    {
        double memory = 0;
        
        Console.Write("Введите первое число a: нельзя делить на 0, нельзя вписывать не числа, нельзя чтоб корень был из отрицательного числа ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите что сделать с числами: ");
        string z = Console.ReadLine();

        Console.Write("Введите второе число b: ");
        int b = int.Parse(Console.ReadLine());
        
        if (!int.TryParse(inputB, out b))
        {
            Console.WriteLine("Ошибка! Введено неправильное число для b.");
            return;
        }

        if (!double.TryParse(inputA, out a))
        {
            Console.WriteLine("Ошибка! Введено неправильное число для a.");
            return;
        }

        if (z == "+")
            Console.WriteLine(a + b);
        if (z == "-")
            Console.WriteLine(a - b);
        if (z == "*")
            Console.WriteLine(a * b);
        if (z == "/")
            Console.WriteLine((double)a / b);
        if (z == "1/a")
            Console.WriteLine(a != 0 ? 1 / a : double.NaN);
        if (z == "**")
            Console.WriteLine(Math.Pow(a, b));
        if (z == "корень(a)")
            Console.WriteLine(a >= 0 ? Math.Sqrt(a) : double.NaN);
        
        
        
        if (z == "M+")
        {
            memory += a;
            Console.WriteLine("Память: " + memory);
        }
        if (z == "M-")
        {
            memory -= a;
            Console.WriteLine("Память: " + memory);
        }
        if (z == "MR")
        {
            Console.WriteLine("Из памяти: " + memory);
    }
        else {
            Console.WritLine("Ошибка! вы не соблюдали правила!");
        }
}
}
