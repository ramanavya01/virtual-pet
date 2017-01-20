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
            Console.WriteLine("Let's Start!");
            Console.WriteLine("\nWe are at the Dragon Egg Store.\nPlease select which egg you want from the options below (enter a number 1-5): ");
            Console.WriteLine("1. Blue Egg for $50");
            Console.WriteLine("2. Purple Egg for $100");
            Console.WriteLine("3. Green Egg for $110");
            Console.WriteLine("4. White Egg for $150");
            Console.WriteLine("5. Gold Egg for $200");

            Console.Write("\nYour number is: ");  
            int option = int.Parse(Console.ReadLine());
        
            switch(option)
            {
                case 1:
                Console.WriteLine("\nYou selected: Blue Egg for $50!");
                    break;
                case 2:
                    Console.WriteLine("\nYou selected: Purple Egg for $100!");
                    break;
                case 3:
            Console.WriteLine("\nYou selected: Green Egg for $110!");
                    break;
                case 4:
            Console.WriteLine("\nYou selected: White Egg for $150!");
                    break;
                case 5:
            Console.WriteLine("\nYou selected: Gold Egg for $200!");
                    break;
                default:
                    break;
        }
            Console.WriteLine("You are now the proud owner of a dragon!");
            Console.Write("\nA week has past and your egg is ready to Hatch. You must rub the egg three times");
            Console.Write("to hatch it. Type \"Hatch\" to start hatching your dragon!  ");
            string hatch = Console.ReadLine();
            Console.WriteLine(Hatch(hatch));
            Console.WriteLine("\nNow it is time to start taking care of your new pet Dragon.");
            Console.WriteLine("Let's start by naming your pet! Enter the name you want for your dragon below: ");
            VirtualPet pet = new VirtualPet("Dragon");
            pet.GetName = Console.ReadLine();
            Console.WriteLine("You have named your dragon " + pet.GetName + "! Great Name!");
            Console.WriteLine("Now you can interact with " + pet.GetName + "! \nWe will choose from a menu of options in order to raise him:\n" );

           // do
            
                pet.MenuDisplayNameandDragon();//always prints out dragons name and the words The Dragon
            Console.WriteLine("Please select which interation you want from the options below(enter a number 1 - 5): ");
                Console.WriteLine("1.Play\n2.Train\n3.Hunt\n4.Eat\n5.Fly\n6.Sleep\n");
            pet.StatusDisplay();
            pet.Selector= int.Parse(Console.ReadLine());

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
            pet.StatusDisplay();//displays the status of the pet's attributes



            //} while(true);


        }
        //hatch method
        static string Hatch (string hatch)
        {
            hatch= ("\n1.....2......3.... Your Dragon has hatched!!\nCongrats, its a boy!");
            return hatch;
        }
       //static public void Play()
       // {
       //     .Energy = "No Energy";

       // }
       //static public void Train()
       // {

       // }
       //static public void Hunt()
       // {

       // }
       // static public void Eat()
       // {

       // }
       // static public void Fly()
       // {

       // }
       // static public void SleepMethod()
       // {

       // }
    }
}
