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
        private int fatigue;
        private int hygiene;

        //TODO fill in more fields


        //this defaut constructor sets options without giving us any options
        public VirtualPet()
        {
            this.name = "Lee";
            this.hunger = 10;
            //TODO account for more fields
            //Added the rest of the variables and assigned default values to them
            this.thirst = 10;
            this.waste = 10;
            this.boredom = 10;
            this.fatigue = 10;
            this.hygiene = 10;
        }

        //TODO how can we set things with our construtor
        public VirtualPet(string name, int hunger, int thirst, int waste, int boredom, int health, int fatigue, int hygiene)
        {

            this.name = name;
            this.hunger = 10;
            this.thirst = 10;
            this.waste = 10;
            this.boredom = 10;
            this.fatigue = 10;
            this.hygiene = 10;
        }

        
        //this method can be called to lower the hunger score (0 means tiger has an empty stomach)
        public void HungerScoreLower()
        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger - 1;
        }

        //this method can be called to alleviate the hunger and raise the hunger score (10 means tiger has a full stomach)
        public void HungerScoreHigher()
        {
            //TODO modify these values to anything you see fit
            //Use if and else if to determine when it's appropriate to raise the pet's hunger score
            if (hunger < 9)
            {

                this.hunger = hunger + 2;
            }


            else if (hunger == 9)
            {
                this.hunger = hunger + 1;
            }
            
            
        }

        
        //TODO we need to add more methods to modify the other fields
        

        //this method can be called to lower the thirst score of the pet tiger
        public void ThirstScoreLower()
        {

            this.thirst = thirst - 1;
        }

        //this method can be called to raise the thirst score of the pet tiger
        public void ThirstScoreHigher()
        {

            //Use if and else if to determine when it's appropriate to raise the pet's thirst score
            if (thirst < 9)
            {

                this.thirst = thirst + 2;
            }


            else if (thirst == 9)
            {
                this.thirst = thirst + 1;
            }
        }

        //this method can be called to lower the waste score of the pet tiger
        public void WasteScoreLower()
        {

            this.waste = waste - 1;
        }

        //this method can be called to raise the waste score of the pet tiger
        public void WasteScoreHigher()
        {

            //Use if and else if to determine when it's appropriate to raise the pet's waste score
            if (waste < 9)
            {

                this.waste = waste + 2;
            }


            else if (waste == 9)
            {
                this.waste = waste + 1;
            }
        }

        //this method can be called to lower the boredom score of the pet tiger
        public void BoredomScoreLower()
        {

            this.boredom = boredom - 2;
        }

        //this method can be called to raise the boredom score of the pet tiger
        public void BoredomScoreHigher()
        {

            //Use if and else if to determine when it's appropriate to raise the pet's boredom score
            if (boredom < 9)
            {

                this.boredom = boredom + 2;
            }


            else if (boredom == 9)
            {
                this.boredom = boredom + 1;
            }

        }

        //this method can be called to lower the fatigue score of the pet tiger
        public void FatigueScoreLower()
        {

            this.fatigue = fatigue - 1;
        }

        //this method can be called to raise the fatigue score of the pet tiger
        public void FatigueScoreHigher()
        {

            this.fatigue = 10;
        }

        //this method can be called to lower the hygiene score of the pet tiger
        public void HygieneScoreLower()
        {

            this.hygiene = hygiene - 1;
        }

        //this method can be called to raise the hygiene score of the pet tiger
        public void HygieneScoreHigher()
        {

            this.hygiene = 10;
        }
        
        



        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
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
