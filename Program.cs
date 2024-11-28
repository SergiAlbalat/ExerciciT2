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
            const string Msg1 = "What method do you want to use?\n1- Iterative\t2- Recursive";
            const string Msg2 = "Write 2 numbers and i will show their product:";
            const string Msg3 = "That's not a method";
            const string Msg4 = "The answer is: {0}";
            const string Error = "The format of the  umber is incorrect";
            int method, firstNum, secondNum, result;
            Console.WriteLine(Msg1);
            try
            {
                do
                {
                    method = int.Parse(Console.ReadLine());
                    Console.WriteLine(!Utils.InRange(method, 0, 3) ? Msg3 : "");
                } while (!Utils.InRange(method, 0, 3));
                Console.WriteLine(Msg2);
                firstNum = int.Parse(Console.ReadLine());
                secondNum = int.Parse(Console.ReadLine());
                switch (method)
                {
                    case 1:
                        result = Utils.MultiplyRussia(firstNum, secondNum);
                        Console.WriteLine(Msg4, result);
                        break;
                    case 2:
                        result = Utils.MultiplyRussiaRecursive(firstNum, secondNum);
                        Console.WriteLine(Msg4, result);
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}