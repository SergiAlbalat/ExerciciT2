using System;
using LlibreriaSergi;
namespace ActivitatsT2
{
    //Precon: L'usuri introdueix un numero
    //Postcon: L'usuari sap si el numero es primer
    public class Activitats
    {
        public static void Main()
        {
            const string Msg1 = "Write a natural number and i will tell you if it's a prime number.";
            const string Msg2 = "It is";
            const string Msg3 = "It's not";
            const string Error = "The format of the  umber is incorrect";
            const int Divisor = 2;
            int num;
            Console.WriteLine(Msg1);
            try
            {
                do
                {
                    num = int.Parse(Console.ReadLine());
                } while (Utils.IsNotNatural(num));
                Console.WriteLine(Utils.IsPrimaryRecursive(num, Divisor) ? Msg2 : Msg3);
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}