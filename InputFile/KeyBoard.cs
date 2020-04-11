using System;
using System.Collections.Generic;
using System.Text;

namespace InputFile
{
    class KeyBoard
    {
        public static void Answer(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            if (d < 0) Console.WriteLine("Дискриминант меньше нуля");
            if (d == 0)
            {
                double x = (-b / (2 * a));
                Console.WriteLine("Дискриминант =0 =>" +
                                        $"x={x}");
            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Дискриминант >0" +
                                            $"x1 = {x1}" +
                                            $"x2 = {x2}");
            }
        }
    }
}
