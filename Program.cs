using System;

namespace Polidrom
{
    class Program
    {
        public static string ReverseDatum(string indata)
            {
            char[] array = indata.ToCharArray();
            Array.Reverse(array);
            return new string(array);
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Försöka skriva en polidrom");

            string indata = Console.ReadLine();
            int compare = String.Compare(indata, ReverseDatum(indata));

            if(String.Equals(indata,ReverseDatum(indata)))
            {
                Console.WriteLine("Datumet är rätt alltså " + indata + " den är polidrom.");            
            }
            else 
            {
                Console.WriteLine( indata + " är inte rätt för att den är inte en polidrom."); 
            }
        }
    }
}