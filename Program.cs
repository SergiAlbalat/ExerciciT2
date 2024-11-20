using System;
using LlibreriaSergi;
namespace ActivitatsT2
{
    //Precon: L'usuari introdueix una quantitat entera de minuts
    //Postcon: L'usuari rep la seva conversió a segons
    public class Activitats
    {
        public static void Main()
        {
            const string Msg1 = "Write a number of minutes, use a integer";
            const string Msg2 = "The conversion to seconds is: {0}";
            const string Error = "The format of the  umber is incorrect";
            int time;
            Console.WriteLine(Msg1);
            try
            {
                time = int.Parse(Console.ReadLine());
                time = Utils.MinToSec(time);
                Console.WriteLine(Msg2, time);
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}