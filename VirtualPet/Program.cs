﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {


        static void Main(string[] args)
        {
            //This section sets the storyline up for the user
            Console.WriteLine("Welcome to Dragon Hatcher!");
            Console.WriteLine("The interactive pet game were you hatch and raise your very own dragon!");
            Console.WriteLine("*If you wish to quit or restart the game type \"Quit\" or \"Restart\" when prompted.");
            Console.WriteLine("Let's Start!");

            Enter();//method to allow user to promt the next part of the game by pressing enter

            Console.WriteLine("We are at the Dragon Egg Store.");
            int bank = Bank();//randomized amount of money
            Console.WriteLine("\nYou have randomly been given $" + bank + " in the bank.\n");//generates a random amount of money
            //Egg options menu
            Console.WriteLine("Please select which egg you want from the options below.\n(enter a number 1-5 or type  \"Quit\" or \"Restart\")");
            Console.WriteLine("1. Blue Egg for $50");
            Console.WriteLine("2. Purple Egg for $100");
            Console.WriteLine("3. Green Egg for $110");
            Console.WriteLine("4. White Egg for $150");
            Console.WriteLine("5. Gold Egg for $200");

            Console.Write("\nYour number is: \n");
            string option = Console.ReadLine();//users input
            RestartorQuit(option);//quit or restart method
            bool tester = false;
            while(!tester)
            {
                if(option=="1" || option == "2" || option == "3" || option == "4" || option == "5")
                {
                    tester = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number 1-5. Try Again!");
                    option = Console.ReadLine();
                }
            }

                bool done = false;//var that breaks the loop
            //Below is a switch case nested in a while loop that prints what egg they choose based on available bank (using if statement).
            while (!done)
            {
                switch (option)
                {
                    case "1":
                        if (bank <= 300)
                        {
                            Console.WriteLine("\nYou selected: Blue Egg for $50!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = Console.ReadLine(); 
                        }
                        break;
                    case "2":
                        if (bank >= 100)
                        {
                            Console.WriteLine("\nYou selected: Purple Egg for $100!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = Console.ReadLine();
                        }
                        break;
                    case "3":
                        if (bank >= 110)
                        {
                            Console.WriteLine("\nYou selected: Green Egg for $110!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = Console.ReadLine();
                        }
                        break;
                    case "4":
                        if (bank >= 150)
                        {
                            Console.WriteLine("\nYou selected: White Egg for $150!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = Console.ReadLine();
                        }
                        break;
                    case "5":
                        if (bank >= 200)
                        {
                            Console.WriteLine("\nYou selected: Gold Egg for $200!");
                            done = true;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't afford this Egg, try again!");
                            Console.Write("Your number is: ");
                            option = Console.ReadLine();
                        }
                        break;
                    default:
                        break;
                }
            }
            //end of While/Switch

            //Storyline continued...
            Console.WriteLine("You are now the proud owner of a dragon egg!");
            Enter();

            //hatching egg
            Console.Write("A week has past and your egg is ready to Hatch. You must rub the egg three times");
            Console.Write("to hatch it. Type \"Rub\" to start hatching your dragon!\n(you can also quit or restart here)\n ");

            string hatch = Console.ReadLine();
            RestartorQuit(hatch);
            bool counter = false;
            //uses Hatch method, checks first input only
            do
            {
                if (hatch.Equals("rub", StringComparison.CurrentCultureIgnoreCase))
                {

                    Hatch(hatch);//method to hatch egg by taking user input three times
                    counter = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Careful! You can only rub your dragon in order to hatch it. Try Again!");
                    hatch = Console.ReadLine();
                }
            }
            while (!counter);

            Console.WriteLine("\nCrack!! Congrats, you have hatched your new baby dragon!");
            Enter();
            Console.WriteLine("Type \"Generate\" to see what color and gender your dragon is!");
            string generate = Console.ReadLine();
            GenerateDragon(generate);//method that randomly generates a color and gender combo

            Console.WriteLine("\nNow it is time to start taking care of your new pet Dragon!");
            Console.WriteLine("Let's start by NAMING your pet! Enter the name you want for your dragon below:\n(you can also quit or restart here) ");
           
            //Below I am instantiating the new pet object and assigning it default pet type
            VirtualPet pet = new VirtualPet("Dragon");

            pet.GetName = Console.ReadLine();//naming and storing the name in GetName property
            RestartorQuit(pet.GetName);
            Console.WriteLine("You have named your dragon " + pet.GetName + "! Great Name!");
            Enter();

            Console.WriteLine("Now you can interact with " + pet.GetName + "! \nWe will choose from a menu of options in order to raise " + pet.GetName + ". Let's Go!!");

            //BEGINNING OF THE LOOP FOR THE INTERACTION MENU!

           bool test = false; //var that breaks do while loop
            do
            {
                int track = pet.Track();//track method, stores value back into track each time loop runs. Acts as a counter
                pet.PrintTrack(); //prints Dragons "age" as he "grows" based on the tracker

                //Breaks the loop if user does one of the following:
                if (pet.Hunger < 0)
                {
                    Console.WriteLine(pet.GetName + "'s Hunger went below zero!");
                    test = false;
                    break;
                }
                if (pet.Food < 0)
                {
                    Console.WriteLine(pet.GetName + "'s Food Stock went below zero!");
                    test = false;
                    break;
                }
                if (pet.Energy < 0)
                {
                    Console.WriteLine(pet.GetName + "'s Energy went below zero!");
                    test = false;
                    break;
                }
                if(track==15)
                {
                    test = false;
                    break;
                }

                //prompts user to start menu again
                Console.WriteLine("(Hit Enter for Interactive Menu Options)");
               
                RestartorQuit(Console.ReadLine());
                pet.MenuDisplayNameandDragon(); //always prints out dragons name and the words The Dragon
                Console.WriteLine("Please select which interaction you want from the options below\n(enter a number 1 - 6 or type \"Quit\" or \"Restart\" here): ");
                Console.WriteLine("1.PLAY\n2.TRAIN\n3.HUNT\n4.EAT\n5.FLY\n6.SLEEP"); //menu of possible interactions

                string selector = Console.ReadLine();//user input as string

                RestartorQuit(selector);//allows user to restart or quit at this point

                pet.Selector = int.Parse(selector);//takes users input a gives it to switch case as int

                //switch case to activate the interaction methods in virtualpet class, based on user selection
                switch (pet.Selector)
                {
                    case 1:
                        pet.Play();
                        break;
                    case 2:
                        pet.Train();
                        break;
                    case 3:
                        pet.Hunt();
                        break;
                    case 4:
                        pet.Eat();
                        break;
                    case 5:
                        pet.Fly();
                        break;
                    case 6:
                        pet.SleepMethod();
                        break;
                    default:
                        break;
                }
            } while (!test);

            //what happens if loop breaks, game over. 
            Console.WriteLine("The game is over :( .\nHit any key to quit or \"Restart\" to continue.");
            RestartorQuit(Console.ReadLine());
        }
        //Methods

        //hatch method
        static void Hatch(string hatch)
        {
            for (int i = 3; i >= 1; i--)
            {
                if (i == 3) { Console.WriteLine(i + "............. Rub Again! (you can hit enter)"); }
                if (i == 2) { Console.WriteLine(i + "...................Rub Again! (you can hit enter)"); }
                if (i == 1) { Console.WriteLine(i + "......................................."); break; }
                hatch = Console.ReadLine();
            }
        }
        //hit enter to continue method
        static void Enter()
        {
            Console.Write("(hit enter to continue)\n");
            Console.ReadLine();
        }
        //random generated bank method
        static int Bank()
        {
            Random randomMoney = new Random();
            int[] money = { 50, 100, 115, 120, 125, 130, 135, 150, 160, 180, 200, 300 };
            int bank = money[randomMoney.Next(money.Length)];
            return bank;
        }
        //method generates dragons color and gender
        static void GenerateDragon(string generate)
        {
            bool value = false;
            do
            {
                if (generate.ToUpper() != "GENERATE")
                {
                    Console.WriteLine("Please enter the correct word, Try Again!");
                    generate = Console.ReadLine();
                }
                else
                {

                    string[] colorsArray = { "Blue Spotted", "Purple and Pink Striped", "Green and Yellow", "Orange, Red, and Black", "Magestic White", "Brown and Olive Spotted" };
                    string[] genderArray = { "Female", "Male" };
                    Random colorrandom = new Random();
                    Random genderrandom = new Random();
                    string color = colorsArray[colorrandom.Next(colorsArray.Length)];
                    string gender = genderArray[genderrandom.Next(genderArray.Length)];
                    string dragonGenerator = "\n***Your new pet is a " + color + " " + gender + " Dragon!***";
                    Console.WriteLine(dragonGenerator);
                    value = false;
                    break;
                }
            } while (!value);
        }
        static void RestartorQuit(string userinput)
        {
            if (userinput.ToUpper() == "QUIT")
            {
                Environment.Exit(0);

            }
            else if (userinput.ToUpper() == "RESTART")
            {
                Main(Environment.GetCommandLineArgs());
                Environment.Exit(0);
            }
        }
    }
}
