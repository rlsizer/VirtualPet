using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
            VirtualPet myPet = new VirtualPet();


            //TODO add a greeting for the user. you can also let the user name the pet if you like
            //Added greeting for user and prompted user to input a name for their pet tiger
            Console.WriteLine("Hello! Welcome to Virtual Pet Tiger.");
            Console.WriteLine("\r\n\r\nYou will be taking care of your very own pet tiger!");
            Console.WriteLine("\r\n\r\nPlease enter a name for your tiger: ");

            //Declare string variable and define it with user-given pet name
            string tigerName = Console.ReadLine();

            //Keep user informed about the name they chose 
            Console.WriteLine("\r\n\r\nAwesome! Meet " + tigerName + ", your new pet tiger!");

            //Declare int variable for user menu selection 
            int selectedOption;

            //Create a do while loop for user menu with options
            do
            {
                //TODO fill this out with more options to interact with the pet
                //Added seven menu options for user
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1 - Feed " + tigerName);
                Console.WriteLine("2 - Give " + tigerName + " a drink of water.");
                Console.WriteLine("3 - Take " + tigerName + " out for a bathroom break.");
                Console.WriteLine("4 - Go on an exciting adventure with " + tigerName);
                Console.WriteLine("5 - Let " + tigerName + " get some sleep.");
                Console.WriteLine("6 - Give " + tigerName + " a bath.");
                Console.WriteLine("7 - Quit the game.");


                //store user selection in variable and convert to int
                selectedOption = int.Parse(Console.ReadLine());

                //call on method to give pet status update
                myPet.MyPetStatus();

                //use switch case to determine reactions to user selections
                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet
                    case 1:

                        myPet.HungerScoreHigher();
                        Console.WriteLine("\r\n\r\nThank you for feeding "+tigerName+"!");
                        break;

                    //TODO we need to add more cases for the other ways to interact with our pet
                    //when the user selects option two we give tiger a drink
                    case 2:

                        myPet.ThirstScoreHigher();
                        Console.WriteLine("\r\n\r\nYou gave "+tigerName+" some water!");
                        break;

                    case 3:

                        myPet.WasteScoreHigher();
                        Console.WriteLine("\r\n\r\n"+ tigerName + " went out for a much needed bathroom break.");
                        break;

                    case 4:

                        myPet.BoredomScoreHigher();
                        Console.WriteLine("\r\n\r\nYou went on a wild adventure with " + tigerName + "!!");
                        break;

                    case 5:

                        myPet.FatigueScoreHigher();
                        Console.WriteLine("\r\n\r\n" + tigerName + " is well-rested now thanks to a nice long cat nap.");
                        break;

                    case 6:

                        myPet.HygieneScoreHigher();
                        Console.WriteLine("\r\n\r\nWonderful!" + tigerName + " is sparkling clean!");
                        break;

                    case 7:

                        Console.WriteLine("Thank you for playing.."+tigerName+" is gonna miss you!!");
                        return;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here
                

                if (selectedOption != 2)
                {
                    myPet.ThirstScoreLower();
                }

                
               

                
                
                myPet.WasteScoreLower();
                myPet.BoredomScoreLower();
                myPet.FatigueScoreLower();
                myPet.HygieneScoreLower();
                

            } while (selectedOption != 7);

        }
    }
}
