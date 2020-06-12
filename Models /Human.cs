using System;

namespace HumanProj.Models_
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get
            {
                return health;
            }
        } 
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human (string name, int strength, int intel, int dex, int health)
        {
            Name = name; 
            Strength = strength; 
            Intelligence = intel;
            Dexterity = dex;
            this.health = health;
        }

        // Add a constructor to assign custom values to all fields


        // Build Attack method
        public void Attack (Human target)
        {
            Random rand = new Random();
            int roll = rand.Next(1, 11);
            int damage = 0;
            if (roll == 10)
            {
                damage = (int) 1.5 * (Strength - (target.health));
                Console.WriteLine($"Great hit! {target.Name} takes {damage} damage!");
            }
            else if (roll > 5 && roll < 9)
            {
                damage = (int) Strength - (target.health);
                Console.WriteLine($"Hit! {target.Name} takes {damage} damage!");
            }
            else
            {
                Console.WriteLine($"It's a miss");
            }
            target.health -= damage;
        }
    }

}