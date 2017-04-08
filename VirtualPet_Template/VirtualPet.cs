using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //We're setting our fields to private here so only the VirtualPet class can modify them directly
        //Declared eight private variables that will be utilized by the main program
        private string name;
        private int hunger;
        private int thirst;
        private int waste;
        private int boredom;
        private int health;
        private int fatigue;
        private int hygiene;


        //TODO fill in more fields

        //this defaut constructor sets options without giving us any options
        public VirtualPet()
        {
            this.name = "Lee";
            this.hunger = 20;
            //TODO account for more fields
            //Added the rest of the variables and assigned default values to them
            this.thirst = 20;
            this.waste = 20;
            this.boredom = 20;
            this.health = 20;
            this.fatigue = 20;
            this.hygiene = 20;
        }

        //TODO how can we set things with our construtor
        public VirtualPet(string name, int hunger, int thirst, int waste, int boredom, int health, int fatigue, int hygiene)
        {

            this.name = name;
            this.hunger = 10;
            this.thirst = 10;
            this.waste = 10;
            this.boredom = 10;
            this.health = 10;
            this.fatigue = 10;
            this.hygiene = 10;
        }

        
        //this method can be called to lower the hunger score (0 means tiger has an empty stomach)
        public void HungerDecrement()
        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger - 1;
        }

        //this method can be called to alleviate the hunger and raise the hunger score (10 means tiger has a full stomach)
        public void HungerAlleviate()
        {   
            //TODO modify these values to anything you see fit
            this.hunger = hunger +2;
        }

        //TODO we need to add more methods to modify the other fields


        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Hunger: " + hunger);
            //TODO account for more fields
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Waste: " + waste);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Fatigue: " + fatigue);
            Console.WriteLine("Hygiene: " + hygiene);
            
        }
    }
}
