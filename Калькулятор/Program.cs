using System.ComponentModel.Design;
using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
Console.WriteLine("Начать программу? (Введите да или нет)");
string vre = Convert.ToString( Console.ReadLine());
if (vre == "да")
{
    do
    {
        Console.WriteLine("Выберите действие");
        Console.WriteLine("1. Сложить 2 числа");
        Console.WriteLine("2.Вычесть первое из второго");
        Console.WriteLine("3.Перемножить два числа");
        Console.WriteLine("4.Разделить первое на второе");
        Console.WriteLine("5.Возвести в степень N первое число");
        Console.WriteLine("6.Найти квадратный корень из числа");
        Console.WriteLine("7.Найти 1 процент от числа");
        Console.WriteLine("8.Найти факториал из числа");
        Console.WriteLine("9.Выйти из программы");
        double Result = 0;
        string p = Console.ReadLine();
        char deistvie = Convert.ToChar(p);
        if (deistvie == '1')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            Console.WriteLine("Введите второе значение");
            string y = Console.ReadLine();
            double vtoroe = Convert.ToDouble(y);
            Result = pervoe + vtoroe;
        }
        else if (deistvie == '2')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            Console.WriteLine("Введите второе значение");
            string y = Console.ReadLine();
            double vtoroe = Convert.ToDouble(y);
            Result = pervoe - vtoroe;
        }
        else if (deistvie == '3')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            Console.WriteLine("Введите второе значение");
            string y = Console.ReadLine();
            double vtoroe = Convert.ToDouble(y);
            Result = pervoe * vtoroe;
        }
        else if (deistvie == '4')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            Console.WriteLine("Введите второе значение");
            string y = Console.ReadLine();
            double vtoroe = Convert.ToDouble(y);
            if (vtoroe == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
                Environment.Exit(0);
            }
            else
            {
                Result = pervoe / vtoroe;
            }
        }
        else if (deistvie == '5')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            Console.WriteLine("Введите степень");
            string y = Console.ReadLine();
            double vtoroe = Convert.ToDouble(y);
            Result = Math.Pow(pervoe, vtoroe);
        }
        else if (deistvie == '6')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            if (pervoe >= 0)
            {
                Result = Math.Sqrt(pervoe);
            }
            else
            {
                Console.WriteLine("Корень не может быть отрицательным");
                Environment.Exit(0);
            }

        }
        else if (deistvie == '7')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            double pervoe = Convert.ToDouble(r);
            Result = pervoe / 100;
        }
        else if (deistvie == '8')
        {
            Console.WriteLine("Введите первое значение");
            string r = Console.ReadLine();
            int pervoe = Convert.ToInt32(r);
            if (pervoe < 0)
            {
                Console.WriteLine("Факториал не может быть отрицательнвм или 0");
                Environment.Exit(0);
            }
            else
            {
                int Tab = 1;
                for (int i = 1; i <= pervoe; i++)
                {
                    Tab = Tab * i;
                }

                Result = Tab;
            }
        }
        else if (deistvie == '9')
        {
            Console.WriteLine("Конец");
            Environment.Exit(0);
        }
        Console.WriteLine(Result);

        Console.WriteLine("Введите операцию еще раз");
    } while (vre == "да");
}
else
{
    Console.Write("Конец");
    Environment.Exit(0);
}
    















