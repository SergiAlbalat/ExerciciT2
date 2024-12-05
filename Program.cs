using System;
using LlibreriaSergi;
namespace ActivitatsT2
{
    //Precon: L'usuari introdueix cuantes temperatures introduira
    //Postcon: L'usuari les temperatures de manera ordenada i en format d'histograma
    public class Activitats
    {
        public static void Main()
        {
            const string Msg1 = "Write a natural number and i wil transform it to binari.";
            const string Msg2 = "Your number is: {0}";
            const string Error = "The format of the  umber is incorrect";
            int num;
            double result;
            Console.WriteLine(Msg1);
            try
            {
                do
                {
                    num = int.Parse(Console.ReadLine());
                } while (Utils.IsNotNatural(num));
                result = Utils.BinaryConvertRecursive(num);
                Console.WriteLine(Msg2, result);
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}