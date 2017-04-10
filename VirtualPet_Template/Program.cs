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
            //Store ASCII art of tiger's face in a string; use Environment.NewLine to connect each line together
            string tigerFace = ("                           _" + Environment.NewLine+
"        __       __       ' `." +Environment.NewLine+
"      .'  `.  .-'\\`-.  ./   |" +Environment.NewLine+
"      |     \\-'-'_\\`-`_/    |" +Environment.NewLine+
"      |      \\--'-\\-._-.'/  )" +Environment.NewLine+
"      \\  \\ .'.'--'|\\`--._`.-'." +Environment.NewLine+
"       )`' .''' .'.-L-.`-.\\ '." +Environment.NewLine+
"      // _'/J '- ///|\\\\|-.``.`'." +Environment.NewLine+
"    .'/'/ .'.-`( | '|` ..-.'( L- L" +Environment.NewLine+
"   // |J J|]`((\"\\)\\ J(\".'`J||- |" +Environment.NewLine+
"  / | |) || Y.`.`\\.' -. L' - J ||| - -" +Environment.NewLine+
" /. ' |`.J|J\\  ))J' / \"-. \\`'/'/-  \""+Environment.NewLine+
"J - -  \\  L\\`.-' || .' \\ \\`'J J  |" +Environment.NewLine+
" | -'_-'. (= `.//.-.__ \" _  L-/.-. |" +Environment.NewLine+
"| -      )_\\\\`|...(`-.\".''.)/ -.  )---" +Environment.NewLine+
" | -'')  `\\.::::.`.|/.:.'`-  ``--._" +Environment.NewLine+
"J - ' -'.'  )./ \\::::::'X::::\\` ``` ____" +Environment.NewLine+
") \\ ' '//  ///''.__-'--`-\\\\ \\ `__" +Environment.NewLine+
"|\\' .' /|/ ' '///  ' \"` \\|\\`` -.`--." +Environment.NewLine+
"| `.'    /.' )  | (       )``-'  . `." +Environment.NewLine+
"J   `.'_.' /  / '''.____.'.'.-' | `.  `" +Environment.NewLine+
"(`.   `-.') . \" _.'. .'  '.'`  `." +Environment.NewLine+
"|`.\\     \'  \\  )' |)/    .- ' |  .'" +Environment.NewLine+
"/  `.\\    `.\\  /|.'//  .-'    J /" +Environment.NewLine+
"     `.     \\`\" )//   //       L" +Environment.NewLine+
"     _ `     ` . /  .''  _.--'' |" +Environment.NewLine+
"    --._      '|`  .'.'-\"\"-` |\";"+Environment.NewLine);

            Console.WriteLine(tigerFace);


            //Declare int variable for user menu selection 
            int selectedOption;

            //Create a do while loop for user menu with options
            do
            {
                //TODO fill this out with more options to interact with the pet
                //Added seven menu options for user
                Console.WriteLine();
                Console.WriteLine(tigerName + " the Tiger");
                Console.WriteLine("\r\n\r\nPlease select an option:");
                Console.WriteLine("1 - Feed " + tigerName+".");
                Console.WriteLine("2 - Give " + tigerName + " a drink of water.");
                Console.WriteLine("3 - Take " + tigerName + " out for a bathroom break.");
                Console.WriteLine("4 - Go on an exciting adventure with " + tigerName+".");
                Console.WriteLine("5 - Let " + tigerName + " get some sleep.");
                Console.WriteLine("6 - Give " + tigerName + " a bath.");
                Console.WriteLine("7 - Quit the game.");
                Console.WriteLine();
                Console.Write("> ");

                //store user selection in variable and convert to int
                selectedOption = int.Parse(Console.ReadLine());
                Console.Clear();
                

                //use switch case to determine reactions to user selections
                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet
                    case 1:

                        myPet.HungerScoreHigher();
                        myPet.ThirstScoreLower(); //Tiger gets thirsty when eating
                        myPet.WasteScoreLower(); //Tiger will have to go to the bathroom
                        Console.WriteLine("\r\n\r\nThank you for feeding "+tigerName+"!");
                        break;

                    //TODO we need to add more cases for the other ways to interact with our pet
                    //when the user selects option two we give tiger a drink
                    case 2:

                        myPet.ThirstScoreHigher();
                        myPet.WasteScoreLower(); //Tiger will have to go to the bathroom
                        Console.WriteLine("\r\n\r\nYou gave "+tigerName+" some water!");
                        break;

                    case 3:

                        myPet.WasteScoreHigher();
                        Console.WriteLine("\r\n\r\n"+ tigerName + " went out for a much needed bathroom break.");
                        break;

                    case 4:

                        myPet.BoredomScoreHigher();
                        myPet.HungerScoreLower(); //Tiger works up an appetite during an adventure
                        myPet.ThirstScoreLower(); //Tiger is thirsty after all that adventuring
                        myPet.FatigueScoreLower(); //Exciting adventures make tiger sleepy
                        Console.WriteLine("\r\n\r\nYou went on a wild adventure with " + tigerName + "!!");
                        break;

                    case 5:

                        myPet.FatigueScoreHigher();
                        myPet.WasteScoreLower(); //Tiger may need to use the bathroom after waking up
                        Console.WriteLine("\r\n\r\n" + tigerName + " is well-rested now thanks to a nice long cat nap.");
                        break;

                    case 6:

                        myPet.HygieneScoreHigher();
                        myPet.BoredomScoreLower(); //Bathing is kinda boring for tiger 
                        Console.WriteLine("\r\n\r\nWonderful! " + tigerName + " is sparkling clean!");
                        break;

                    case 7:

                        Console.WriteLine("Thank you for playing.. "+tigerName+" is gonna miss you!!");
                        Console.WriteLine("\r\n\r\nPlease help support Tiger conservation efforts: \r\n\r\nPeople and tigers increasingly compete for space.\r\nThe conflict threatens the world’s remaining wild tigers and poses a major problem for communities living in or near forests with tigers.\r\nAs forests shrink and prey gets scarce, tigers are forced to hunt domestic livestock, which many local communities depend on for their livelihood.\r\nIn retaliation, tigers are killed or captured.\r\n“Conflict” tigers are known to end up for sale in black markets.\r\nLocal community dependence on forests for fuelwood, food and timber heightens the risk of tiger attacks on people.\r\nContact the World Wildlife Foundation for more information.");
                        return;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                Console.WriteLine();
                //Print out tiger face to console before each status update
                Console.WriteLine(tigerFace);
                //call on method to give pet status update
                myPet.MyPetStatus();
                //call on method to let pet do random stuff
                myPet.UnpredictablePet();
                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here

                //Use if statements to determine when each score should automatically lower based upon user selections
                if (selectedOption != 1)
                {
                    myPet.HungerScoreLower();
                }


                if (selectedOption != 4)
                {
                    myPet.BoredomScoreLower();
                }

                if (selectedOption != 5)
                {
                    myPet.FatigueScoreLower();
                }

                if (selectedOption != 6)
                {
                    myPet.HygieneScoreLower();
                    
                }

                


            } while (selectedOption != 7);
            
            
        }
    }
}
