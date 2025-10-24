using Operation;
using System;
Operations operations = new();

while (true)
{
    Console.WriteLine("Запустить простой калькулятор или инженерный\n1-простой\n2-инженерный");
    string CalcInput = Console.ReadLine();
    if (CalcInput == "1")
    {
        Console.WriteLine("Введите значение для первого числа");
        string Num1Input = Console.ReadLine();
        int num1 = int.Parse(Num1Input);
        Console.WriteLine("Введите значение для второго числа");
        string Num2Input = Console.ReadLine();
        int num2 = int.Parse(Num2Input);
        Console.WriteLine("Выберите операцию:\n+\n-\n*\n/");
        string ChoseInput = Console.ReadLine();
        if (ChoseInput == "+")
        {
            Console.WriteLine(operations.Sum(num1, num2));
        }
        else if (ChoseInput == "-")
        {
            Console.WriteLine(operations.Subtraction(num1, num2));
        }
        else if (ChoseInput == "*")
        {
            Console.WriteLine(operations.Multiplication(num1, num2));
        }
        else if (ChoseInput == "/")
        {
            Console.WriteLine(operations.Division(num1, num2));
        }
    }
    else if (CalcInput == "2")
    {
        Console.WriteLine("Введите число:");
        string Input = Console.ReadLine();
        int num3 = int.Parse(Input);
        Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц, 7 - выход");
        string Math = Console.ReadLine();
        if (Math == "1")
        {
            Console.WriteLine(operations.Exponentiation2(num3));
        }
        else if (Math == "2")
        {
            Console.WriteLine(operations.Exponentiation3(num3));
        }
        else if (Math == "3")
        {
            Console.WriteLine(operations.Root(num3));
        }
        else if (Math == "4")
        {
            Console.WriteLine(operations.Cos(num3));
        }
        else if (Math == "5")
        {
            Console.WriteLine(operations.Sin(num3));
        }
        else if (Math == "6")
        {
            Console.WriteLine(operations.Tan(num3));
        }
        else if (Math == "7")
        {
            break;
        }

    }
    else
    {
        Console.WriteLine("Введите 1 либо 2");
        Console.ReadKey();
        break;
    }
}