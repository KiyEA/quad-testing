using System;
using System.Collections.Generic;
using System.Text;

namespace InputFile
{
    class Program
    {
        static void Main(string[] args)
    {
        int choice = 4;
        while (choice != 0)
        {
            Console.WriteLine("Введите"
                + "1) заполнениес клавиатуры"
                 + "2) заполнение с файла"
                + "0) Выход");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Введите а =");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите b =");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите c =");
                    double c = Convert.ToDouble(Console.ReadLine());
                    if (a == 0)
                    {
                        Console.WriteLine("Это не квадратное уравнение");
                        break;
                    }
                    KeyBoard.Answer(a, b, c);
                    break;
                case 2:
                    Console.WriteLine("Введите путь к файлу");
                    string uri = Console.ReadLine();
                    InputFromFile n = new InputFromFile();
                    n.FromFile(uri);
                    break;
                default:
                    break;
            }
        }
    }
}
}
