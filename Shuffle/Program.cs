using System;
using System.Collections.Generic;
using System.Linq;

namespace Shuffle
{
    class Program
    {

        //public class Randomizer
        //{

        //    public static void Randomize<T>(T[] items)
        //    {
        //        Random rand = new Random();

        //        for (int i = 0; i < items.Length; i++)
        //        {
        //            int j = rand.Next(i, items.Length);
        //            T temp = items[i];
        //            items[i] = items[j];
        //            items[j] = temp;
        //        }
        //    }

        //}

        static void Main(string[] args)
        {
            string[] studenti = new string[] {      "Simone G", 
                                                    "Giulia O", 
                                                    "Andrea B", 
                                                    "Andrea G", 
                                                    "Andrea C", 
                                                    "Lorena S", 
                                                    "Elia G", 
                                                    "Stefano M",
                                                    "Stefano B", 
                                                    "Alessio T", 
                                                    "Alberto D", 
                                                    "Paolo I" };


            Console.WriteLine("Elenco degli studenti:");

            for (int i = 0; i < studenti.Length; i++)
            {
                    Console.WriteLine(studenti[i]);
            }


            Random r = new Random();

            studenti = studenti.OrderBy(x => r.Next()).ToArray();

            //Randomizer.Randomize(studenti);

            Console.WriteLine("\n");
            Console.WriteLine("Nuova disposizione:");

            for (int k = 0; k < studenti.Length; k++)
            {
                Console.WriteLine(studenti[k] + " e " + studenti[k+1]+ " --- " + studenti[k+2] + " e " + studenti[k+3]);
                k = k+3;
            }

        }
    }
}