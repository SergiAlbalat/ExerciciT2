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
            const string Msg1 = "How many temperatures do you want to store?(Cº)";
            const string Msg2 = "Write a temperature:";
            const string Msg3 = "What do you want to do?\n1- Order temperatures and write.\n2- Search if there is a specific temperature stored\n3- Make an histogram with the values.\n4- Exit";
            const string Msg4 = "What temperature do you want to know if it's stored?";
            const string Msg5 = "It's stored!";
            const string Msg6 = "It's not stored";
            const string Error = "The format of the  umber is incorrect";
            const int MinOption = 1;
            const int MaxOption = 4;
            int quantity, option;
            bool exit = false;
            try
            {
                do
                {
                    Console.WriteLine(Msg1);
                    quantity = int.Parse(Console.ReadLine());
                }while(Utils.IsNotNatural(quantity));
                double[] temperatures = new double[quantity];
                for(int i = 0; i < temperatures.Length; i++)
                {
                    Console.WriteLine(Msg2);
                    temperatures[i] = double.Parse(Console.ReadLine());
                }
                do
                {
                    do
                    {
                        Console.WriteLine(Msg3);
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                temperatures = Utils.OrdenarArray(temperatures);
                                Utils.EscribirArrays(temperatures);
                                break;
                            case 2:
                                double filter;
                                Console.WriteLine(Msg4);
                                filter = double.Parse(Console.ReadLine());
                                Console.WriteLine(Utils.BuscarEnArray(temperatures, filter) ? Msg5 : Msg6);
                                break;
                            case 3:
                                Utils.ArrayHistograma(temperatures);
                                break;
                            case 4:
                                exit = true;
                                break;
                        }
                    } while (Utils.InRange(option, MinOption, MaxOption));
                }while(!exit);
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}