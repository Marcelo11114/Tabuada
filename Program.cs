using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sair;
            do{
            Console.Clear();
            int Mult;
           
            Console.WriteLine("      +---------+");
            Console.WriteLine("      | TABUADA |");
            Console.WriteLine("      +---------+\n");
            Console.Write("Qual tabuada deseja ?");
            Mult = Convert.ToInt16(Console.ReadLine());

            for (int i=0; i<=10; i++)
            {
                Console.WriteLine($"{Mult} X {i} = {Mult*i}");
            }

            Console.Write("n/Outra ?(s)");
            Sair=Console.ReadLine().ToUpper();
            } while (Sair == "S");
            Console.Clear();






            
        }
    }
}
