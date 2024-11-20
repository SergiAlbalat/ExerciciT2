using System;
using LlibreriaSergi;
namespace ActivitatsT2
{
    //Precon: L'usuari introdueix una temperatura en Celsius
    //Postcon: L'usuari rep la temperatura en Fahrenheit
    public class Activitats
    { 
        public static void Main()
        {
            const string Msg1 = "Write a celsius temperature";
            const string Msg2 = "The temperature in fahrenheit is: {0}";
            const string Error = "The format of the  umber is incorrect";
            double temperature;
            Console.WriteLine(Msg1);
            try
            {
                temperature = double.Parse(Console.ReadLine());
                temperature = Utils.CelsiusToFahrenheit(temperature);
                Console.WriteLine(Msg2, Math.Round(temperature, 2));
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}