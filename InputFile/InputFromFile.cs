using System;
using System.Linq;
using System.IO;

namespace InputFile
{
    public class InputFromFile
    {
        public double x1;
        public double x;
        public double x2;
        public bool FromFile(string uri)
        {
            double[] arr = File.ReadAllText(uri).Split(' ').Select(q=> double.Parse(q)).ToArray();
            double a = arr[0];
            if (a == 0) { return false; throw new NotImplementedException("this is not quadratic equation"); }
            double b = arr[1];
            double c = arr[2];
            double d = b * b - 4 * a * c;
            Console.WriteLine($"{c}");
            if (d < 0) Console.WriteLine("Дискриминант меньше нуля");
            InputFromFile n = new InputFromFile();
            if (d == 0)
            {
                n.x = (-b / (2 * a));
                Console.WriteLine("Дискриминант =0 =>" +
                    $"x={n.x}");
            }
            if (d > 0)
            {
                n.x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                n.x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("Дискриминант >0" +
                    $"x1 = {n.x1}" +
                    $"x2 = {n.x2}");
            }
            return true;
        }
    }
}
