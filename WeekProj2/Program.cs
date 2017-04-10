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
            Console.WriteLine("Hello and congratulations on your newest pet! \nMost people want a dog or cat for a companion, but not you! \nYou know the best companions still have a bit of the wild in them! \n");
            Console.Write("\nWithout further dealy, straight from Eastern Asia, here is your very own Asiatic Wild Dog, the Dhole! \n-If anyone asks, just say it's a mixed shepherd breed! \nWhy don't you choose a name for your new friend?");
            myPet.name = Console.ReadLine();

            Console.WriteLine("\nSplendid! I'm sure you and " + myPet.name + " will get along great! \nSelect any number 1-10 to begin! \n");

            Console.WriteLine("\n   ^__\n   | '`;\n   /\\|\n  /  |\n(/_)_|_");

            int selectedOption;

            do
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("Your pet's current status is: ");
                myPet.MyPetStatus();
                Console.WriteLine("*********************************************\n");


                Console.WriteLine();
                Console.WriteLine("\nPlease select an option: ");
                Console.WriteLine("\n1. Feed" + myPet.name + "!");
                Console.WriteLine("\n2. Give " + myPet.name + " water");
                Console.WriteLine("\n3. Play with" + myPet.name + "!");
                Console.WriteLine("\n4. Take " + myPet.name + " on a walk!");
                Console.WriteLine("\n5. Let " + myPet.name + " sleep when tiredness is 35 or more");
                Console.WriteLine("\n6. Let " + myPet.name + " outside when bathroom needs are 40 or more");
                Console.WriteLine("\n7. Take " + myPet.name + " to the vet when health drops below 50!");
                Console.WriteLine("\n10. Quit");

                bool trueF;
                trueF = int.TryParse(Console.ReadLine(), out selectedOption);


                while (trueF == false)
                {
                    Console.Write("Invalid option selected, try again!  Please select an option: \n");
                    trueF = int.TryParse(Console.ReadLine(), out selectedOption);
                }
                if (trueF == true)
                {
                    switch (selectedOption)
                    {
                        /*Hunger
                         -Feed Pet! */

                        case 1:
                            if (myPet.hunger <= 0)
                            {
                                Console.WriteLine("\nIt looks like " + myPet.name + "'s full for the moment...");
                                break;
                            }

                            else if (myPet.hunger >= 75 && myPet.hunger <= 90)
                            {
                                Console.WriteLine("\nPoor " + myPet.name + " was absolutely ravenous! You should remember to feed " + myPet.name + " more often!");
                                break;
                            }

                            else
                            {
                                myPet.Meal();
                                Console.WriteLine("\nLooks like " + myPet.name + " really enjoyed the meat you fed her" );
                                break;
                            }


                        /*Thirst:
                         -Give pet water! */

                        case 2:
                            if (myPet.thirst <= 0)
                            {
                                Console.WriteLine("\nIt looks like " + myPet.name + " doesn't want any more water right now...");
                                break;
                            }

                            else if (myPet.thirst >= 75 && myPet.thirst <= 90)
                            {
                                Console.WriteLine("\nPoor " + myPet.name + " was so thirsty! You should try to keep " + myPet.name + " well hydrated!");
                                break;
                            }

                            else
                            {
                                myPet.ThirstDecrease();
                                Console.WriteLine("\n" + myPet.name + " really seemed to appreciate the water!");
                                break;
                            }


                        /*Boredom:
                         * -Play with your pet! Decreases Boredom and Restlessness, but increases thirst and tiredness. */

                        case 3:

                            if (myPet.boredom >= 75 && myPet.boredom <= 90)
                            {
                                myPet.OverlyBored();
                                Console.WriteLine("\nNothing like a nice long play session! " + myPet.name + "really wanted to play with you!");
                                break;
                            }

                            else if (myPet.restless >= 4 && myPet.restless <= 74)
                            {
                                myPet.BoredomDecrease();
                                Console.WriteLine("\nAw! " + myPet.name + " loves playing with you!");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nLooks like " + myPet.name + " isn't interested in playing at the moment");
                                break;
                            }
                            
                        /*Restlessness:
                        -Take your pet on a walk! Decreases restlessness and boredom of pet, but increases thirst and tiredness! */

                        case 4:

                            if (myPet.restless >= 75 && myPet.restless <= 90)
                            {
                                myPet.OverlyRestless();
                                Console.WriteLine("\nWoah...it looks like " + myPet.name + " really wanted a walk! -You should try walking " + myPet.name + " more ofter!");
                                break;
                            }

                            else if (myPet.restless >= 4 && myPet.restless <= 74)
                            {
                                myPet.RestlessDecrease();
                                Console.WriteLine("\nIt looks like " + myPet.name + " had fun on your walk!");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nHm, it looks like " + myPet.name + " is content and doesn't plan on moving right now");
                                break;
                            }


                        /*Tiredness:
                        -Let your pet sleep (35 and above)! Decreases tiredness, restlessness and boredom of pet, but increases hunger and thirst!  */

                        case 5:
                            if (myPet.tired >= 50 && myPet.tired <= 90)
                            {
                                myPet.TiredDecrease();
                                Console.WriteLine("\n" + myPet.name + " is sleeping peacefully!");
                                break;
                            }

                            else if (myPet.tired >= 35 && myPet.tired <= 49)
                            {
                                myPet.QuickNap();
                                Console.WriteLine("\n" + myPet.name + " looks refreshed after that nap!");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nIt looks like " + myPet.name + " just isn't tired right now!");
                                break;
                            }


                        /*Bathroom Needs:
                        -Let your pet outside (40 and above)! Decreases pet's bathroom needs!: */

                        case 6:
                            if (myPet.potty >= 40 && myPet.potty <= 74)
                            {
                                myPet.InAndOut();
                                Console.WriteLine("\nThank you for remembering to let " + myPet.name + " out!");
                                break;
                            }

                            else if (myPet.potty >= 75 && myPet.potty <= 90)
                            {
                                myPet.PottyDecrease();
                                Console.WriteLine("\nJust in time!");
                                break;
                            }

                            else
                            {
                                myPet.ThirstDecrease();
                                Console.WriteLine("\nLooks like" + myPet.name + " is fine for the moment!");
                                break;
                            }


                        /*Health: 
                         -Increase your pet's health by visiting the doctor when health is below 50! 
                         -Taking care of your pet will also cause slight health increases!*/

                        case 7:
                            if (myPet.health >= 36 && myPet.health <= 50)
                            {
                                myPet.HealthIncrease();
                                Console.WriteLine("\n" + myPet.name + " is feeling much better after that checkup!");
                                break;
                            }

                            else if (myPet.health >= 10 && myPet.health <= 35)
                            {
                                myPet.HealthIncrease();
                                Console.WriteLine("\nThat was a close call, but " + myPet.name + " will be just fine!");
                                break;
                            }

                            else if (myPet.health >= 0 && myPet.health <= 9)
                            {
                                Console.WriteLine("\nMy goodness, have your been taking proper care of " + myPet.name + "at all?");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nThat's not necessary right now " + myPet.name + " is perfectly healthy!");
                                break;
                            }

                        /*End Game!
                        -Chose to leave this as 10 so it is harder for the user to quit program by accident! */

                        case 10:

                            Console.WriteLine("\nThank you for playing.");
                            break;


                        //Default

                        default:

                            Console.WriteLine("\nInvalid option selected.");
                            break;
                    }
                }



                //Pet Takes care of itself if: ...

                while (myPet.tired >= 91)
                {
                    myPet.TiredDecrease();
                    Console.WriteLine("\nLooks like " + myPet.name + " has fallen asleep on you! \nEven wild doogs like Dholes need rest once in a while!");
                    break;
                }

                while (myPet.potty >= 91)
                {
                    myPet.PottyDecrease();
                    Console.WriteLine("\nOh No! It looks like " + myPet.name + " had an accident! \nMaybe you should have payed more attention to all of " + myPet.name + "'s needs?");
                    break;
                }

                while (myPet.boredom >= 91)
                {
                    myPet.OverlyBored();
                    Console.WriteLine("\nUh-oh! It looks like " + myPet.name + " has had fun tearing up the sofa! \nMaybe you should play with " + myPet.name + " more often?");
                    break;
                }



                //Automatic Game over if: ...

                while (myPet.health <= 9)
                {
                    Console.WriteLine("\nSorry, because you have failed to keep " + myPet.name + " healthy, the Animal Humane Society has decided you are not fit for a pet!  \nCharges will be filed!");
                    selectedOption = myPet.end;
                    break;
                }

                while (myPet.hunger >= 91)
                {
                    Console.WriteLine("\nPoor " + myPet.name + " is extreley malnourished! \nThe Animal Humane Society has decided you are not fit for a pet! Charges will be filed!");
                    Console.WriteLine("\nFurthermore, additional charges shall be filed because " + myPet.name + " has been determined to be an \nAsiatic Wild Dog and you do not have the proper license, or enclosure, for such an animal!");
                    selectedOption = myPet.end;
                    break;
                }

                while (myPet.thirst >= 91)
                {
                    Console.WriteLine("\nPoor " + myPet.name + " is extreley dehydrated! \nThe Animal Humane Society has decided you are not fit for a pet! Charges will be filed!");
                    Console.WriteLine("\nFurthermore, additional charges shall be filed because " + myPet.name + " has been determined to be an \nAsiatic Wild Dog and you do not have the proper license, or enclosure, for such an animal!");
                    selectedOption = myPet.end;
                    break;
                }

                while (myPet.restless >= 91)
                {
                    Console.WriteLine("\nOh NO! It appears you left the garage door open and " + myPet.name + " got out!  \nDholes are free spirits, maybe you should have walked " + myPet.name + " more often?");
                    selectedOption = myPet.end;
                    break;
                }


                //Automatically changes values for pet.:

                myPet.HealthDecrease();
                myPet.HungerIncrease();
                myPet.ThirstIncrease();
                myPet.BoredomIncrease();
                myPet.RestlessIncrease();
                myPet.TiredIncrease();
                myPet.PottyIncrease();


            } while (selectedOption != 10);

       


        }
    }
}
