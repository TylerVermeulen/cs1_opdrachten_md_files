using System;

namespace VariableOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //maak hier 3 local variables aan:
            //1 type=string, naam: name, waarde je favoriete rpg character
            string name = "Gorlock the Destroyer";
            //2 type=int, naam: hp, een waarde van hoeveel health dit character heeft
            int hp = 9999;
            //3 type=int, naam: str, een waarde van hoe sterk dit character is
            int str = 150;


            //nu zou de statement hieronder moeten werken
            Console.WriteLine($"{name} {hp} {str}");
        }
    }

}