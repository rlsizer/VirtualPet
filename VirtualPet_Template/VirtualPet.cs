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
            if (hunger <= 10 && hunger > 0)
            {
                this.hunger = hunger - 1;
            }
            
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
            if (thirst <= 10 && thirst > 0)
            {
                this.thirst = thirst - 1;
            }
            
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
            if (waste <= 10 && waste > 0)
            {
                this.waste = waste - 1;
            }
            
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
            if (boredom <= 10 && boredom > 0)
            {
                this.boredom = boredom - 1;
            }
            
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
            if (fatigue <= 10 && fatigue > 0)
            {
                this.fatigue = fatigue - 1;
            }
            
        }

        //this method can be called to raise the fatigue score of the pet tiger
        public void FatigueScoreHigher()
        {

            //Use if and else if to determine when it's appropriate to raise the pet's fatigue score
            if (fatigue < 9)
            {

                this.fatigue = fatigue + 2;
            }


            else if (fatigue == 9)
            {
                this.fatigue = fatigue + 1;
            }
        }

        //this method can be called to lower the hygiene score of the pet tiger
        public void HygieneScoreLower()
        {
            if (hygiene <= 10 && hygiene > 0)
            {
                this.hygiene = hygiene - 1;
            }
        
        }

        //this method can be called to raise the hygiene score of the pet tiger
        public void HygieneScoreHigher()
        {

            //Use if and else if to determine when it's appropriate to raise the pet's hygiene score
            if (hygiene < 9)
            {

                this.hygiene = hygiene + 2;
            }


            else if (hygiene == 9)
            {
                this.hygiene = hygiene + 1;
            }
        }
        
        



        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            //TODO account for more fields
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Waste: " + waste);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Fatigue: " + fatigue);
            Console.WriteLine("Hygiene: " + hygiene);
            
        }

        public void UnpredictablePet()
        {
            switch (new Random().Next(1, 4))
            {
                case 1:
                    HungerScoreHigher();
                    Console.WriteLine("\r\n\r\nTiger devoured some tasty wildebeest!");
                    break;

                case 2:
                    ThirstScoreHigher();
                    Console.WriteLine("\r\n\r\nTiger enjoyed a refreshing drink from the river.");
                    break;

                case 3:
                    BoredomScoreHigher();
                    Console.WriteLine("\r\n\r\nTiger ventured into the jungle for some fun and pranks!");
                    break;

                case 4:
                    FatigueScoreHigher();
                    Console.WriteLine("\r\n\r\nTiger sleepy! Time for a power cat nap!");
                    break;

                
            }
        }

    }
}
