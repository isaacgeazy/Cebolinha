using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string diga;

           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("-------------- Fale igual ao Cebolinha ---------------");
           Console.ResetColor();
           Console.Write("Digite algo: ");
           diga = Convert.ToString(Console.ReadLine());
           Console.WriteLine();
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine($"{diga.Replace("r", "l")}");
           Console.ResetColor();
             
             
        }
    }
}
