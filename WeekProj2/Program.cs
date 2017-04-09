using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new instance of pet
            VirtualPet myPet = new VirtualPet();

            //Greeting!
            Console.WriteLine("Hello and congratulations on your newest pet!  First things first, please give \nyour pet a name!");
            myPet.name = Console.ReadLine();

            Console.WriteLine("\nGreat!  I'm sure you and " + myPet.name + " will get along great!  Select any number 1-10 to \nbegin!");

            int selectedOption;

            do
            {

                //TODO Add more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("\nPlease select an option: ");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Give the pet water");
                Console.WriteLine("3. Take pet to doctor when health drops below 50!");
                Console.WriteLine("4. Play with the pet");
                Console.WriteLine("10. Quit");

                bool trueF;
                trueF = int.TryParse(Console.ReadLine(), out selectedOption);

                myPet.MyPetStatus();


                while (trueF == false)
                {
                    Console.Write("Invalid option selected, try again!  Please select an option: \n");
                    trueF = int.TryParse(Console.ReadLine(), out selectedOption);
                }
                if (trueF == true)
                {
                    switch (selectedOption)
                    {
                        //when the user selects option one we feed the pet
                        case 1:

                            myPet.HungerDecrease();
                            Console.WriteLine("\nThank you for feeding " + myPet.name);
                            break;

                        case 2:

                            myPet.ThirstDecrease();
                            Console.WriteLine("\n" + myPet.name + " really seemed to appreciate the water!");
                            break;
                        case 3:
                            if (myPet.health >= 36 && myPet.health <= 50)
                            {
                                myPet.HealthIncrease();
                                Console.WriteLine("\n" + myPet.name + " is feeling much better after that checkup!");
                                break;
                            }
                            else if (myPet.health <= 35)
                            {
                                myPet.HealthIncrease();
                                Console.WriteLine("\nThat was a close call " + myPet.name + " is feeling much better now!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nThat's not necessary right now " + myPet.name + " is feeling perfectly fine!");
                                break;
                            }
                        case 4:

                            myPet.BoredomDecrease();
                            Console.WriteLine("\nAw! " + myPet.name + " loves playing with you!");
                            break;

                        //TODO Add more cases for the other ways to interact with our pet

                        case 10:

                            Console.WriteLine("\nThank you for playing.");
                            break;

                        default:

                            Console.WriteLine("\nInvalid option selected.");
                            break;
                    }
                }


                //Put method calls here so the pet can have values change automatically.

                myPet.HungerIncrease();
                myPet.ThirstIncrease();
                myPet.HealthDecrease();
                myPet.BoredomIncrease();


            } while (selectedOption != 10);

       


        }
    }
}
