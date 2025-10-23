using Calculator;
using InterfaceCalculator;
using System;
Calculate secondcalculating = new Calculate();
while (true)
{
    {
        Console.WriteLine("Введите число:");
        string Input = Console.ReadLine();
        int num3 = int.Parse(Input);
        Console.WriteLine("Выберите операцию(1 - возведение в квадрат, 2 - возведение в куб, 3 - корень числа, 4 - косинус, 5 - синус, 6 - тангенц, 7 - выход");
        string Math = Console.ReadLine();
        if (Math == "1")
        {
            Console.WriteLine(secondcalculating.Exponentiation2(num3));
        }
        else if (Math == "2")
        {
            Console.WriteLine(secondcalculating.Exponentiation3(num3));
        }
        else if (Math == "3")
        {
            Console.WriteLine(secondcalculating.Root(num3));
        }
        else if (Math == "4")
        {
            Console.WriteLine(secondcalculating.Cos(num3));
        }
        else if (Math == "5")
        {
            Console.WriteLine(secondcalculating.Sin(num3));
        }
        else if (Math == "6")
        {
            Console.WriteLine(secondcalculating.Tan(num3));
        }
        else if (Math == "7")
        {
            break;
        }
        else
        {
            break;
        }
    }
}
