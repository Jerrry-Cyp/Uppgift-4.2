using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int x;
        int högstanummer = int.MinValue;
        bool förstatal = true;
        while (true)
        {
            if (förstatal)
            {
                Console.Write("Skriv ett heltal:");
                x = int.Parse(Console.ReadLine());
                högstanummer = x;
                förstatal = false;
            }
            
            Console.WriteLine("Vill du skriva ett till tal? (y/n)");
            string y = Console.ReadLine();
            if (y == "y")
            {
                Console.Write("Skriv ett heltal:");
                x = int.Parse(Console.ReadLine());
                if (x > högstanummer)
                {
                    högstanummer = x;
                    
                }
            }
            else break;
        }
        Console.WriteLine("Ditt största tal var: " + högstanummer);
        
    }
}