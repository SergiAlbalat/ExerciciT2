using System;
using LlibreriaSergi;
namespace ActivitatsT2
{
    //Precon: L'usuari intodueix un nombre decimal
    //Postcon: L'usuari rep el nombre enter i la part decimal separades
    public class Activitats
    {
        public static void Main()
        {
            const string Msg1 = "Write a decimal number:";
            const string Msg2 = "The integer part of the number is: {0}";
            const string Msg3 = "The decimal part of the number is: {0}";
            const string Error = "The format of the  umber is incorrect";
            double num;
            Console.WriteLine(Msg1);
            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(Msg2, Utils.DecimalIntPart(num));
                Console.WriteLine(Msg3, Utils.DecimalDecimalPart(num));
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}