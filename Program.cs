using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHuman
{
#nullable enable
    public class Human
    {
        public string? name;
        private int strength;
        private int intelligence;
        private int dexterity;
        public int health;

        public Human()
        {
            //name = "Folk";
            Initialize(3, 3, 3, 100);
        }

        public Human(string humanName)
        {
            //name = humanName;
            Initialize(3, 3, 3, 100);
        }

        public Human(string humanName, int humanStrength, int humanIntelligence, int humanDexterity, int humanHealth)
        {
            name = humanName;
            Initialize(humanStrength, humanIntelligence, humanDexterity, humanHealth);
        }

        private void Initialize(int humanStrength, int humanIntelligence, int humanDexterity, int humanHealth)
        {
            strength = humanStrength;
            intelligence = humanIntelligence;
            dexterity = humanDexterity;
            health = humanHealth;
        }

        public void Attack(object h)
        {
            if (h is Human && (h as Human)!.name == name)
                Console.WriteLine("Can't hurt yourself!");

            if (h is Human && (h as Human)!.name != name)
                (h as Human)!.health -= (h as Human)!.strength * 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human h1 = new Human("H1", 5, 4, 3, 100);
            Human h2 = new Human("H2");
            h1.Attack(h2);
            h1.Attack(h2);
            h1.Attack(h2);
            h2.Attack(h1);
            h1.Attack(h1);
            Console.WriteLine("Health of " + h1.name + " = " + h1.health);
            Console.WriteLine("Health of " + h2.name + " = " + h2.health);

            Console.ReadKey();
        }
    }
}
