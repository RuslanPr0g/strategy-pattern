using StrategyPattern.Characters;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();

            characters.Add(new Queen());
            characters.Add(new King());
            characters.Add(new Troll());
            characters.Add(new Knight());

            Fight(characters);

            characters[0].SetWeapon(new KnifeBehavior()); // using new will be fixed in the Factory pattern
            characters[1].SetWeapon(new AxeBehavior()); // using new will be fixed in the Factory pattern
            characters[2].SetWeapon(new SwordBehavior()); // using new will be fixed in the Factory pattern
            characters[3].SetWeapon(new BowAndArrowBehavior()); // using new will be fixed in the Factory pattern
        
            Fight(characters);
        }

        static void Fight(List<Character> cs)
        {
            foreach (Character c in cs)
            {
                Console.WriteLine($"{ c.GetType().Name } fights - { c.Fight() }");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
