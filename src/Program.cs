using System;

namespace HexColorToDecimal
{
    static class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Input seven digit hex string, e.g. #FF0000, or press Ctrl+Break to exit.");
                Console.Write("> ");

                try
                {
                    var hexColor = Console.ReadLine().Substring(1);

                    var red = hexColor.Substring(0, 2);
                    var green = hexColor.Substring(2, 2);
                    var blue = hexColor.Substring(4, 2);

                    var redValue = Convert.ToInt32(red, 16);
                    var greenValue = Convert.ToInt32(green, 16);
                    var blueValue = Convert.ToInt32(blue, 16);

                    Console.WriteLine($"Colors: {redValue}, {greenValue}, {blueValue}\n");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}