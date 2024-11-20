using System;
using LlibreriaSergi;
namespace ActivitatsT2
{
    //Precon: L'usuari introdueix dos numeros
    //Postcon: L'usuari quin dels dos es més gran i quin es més petit
    public class Activitats
    {
        public static void Main()
        {
            const string Msg1 = "Write two numbers and i will tell you what number is bigger.";
            const string Msg2 = "The first number is bigger than the second.";
            const string Msg3 = "The second number is bigger than the first.";
            const string Msg4 = "The numbers are the same";
            const string Error = "The format of the  umber is incorrect";
            int firstNum, secondNum;
            Console.WriteLine(Msg1);
            try
            {
                firstNum = int.Parse(Console.ReadLine());
                secondNum = int.Parse(Console.ReadLine());
                if (firstNum == secondNum)
                {
                    Console.WriteLine(Msg4);
                }
                else
                {
                    Console.WriteLine(Utils.BiggerThan(firstNum, secondNum) ? Msg2 : Msg3);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}