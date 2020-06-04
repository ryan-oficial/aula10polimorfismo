using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\nMario:");
            Mario Mario = new Mario();
            Mario.Correr();
            Mario.Pular();
            Mario.Montar();

            System.Console.WriteLine("\nLuigi:");
            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
            luigi.Montar();

            System.Console.WriteLine("\nPeach:");
            Peach Peach = new Peach();
            Peach.Correr();
            Peach.Pular();
            Peach.Planar();
            Peach.Montar();

            System.Console.WriteLine("\nBowser:");
            Bowser Bowser = new Bowser();
            Bowser.Pular();
            Bowser.Correr();
            Bowser.AtirarBolaFogo();

        }
    }
}
