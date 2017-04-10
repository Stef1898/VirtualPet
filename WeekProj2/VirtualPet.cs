using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekProj2
{
    class VirtualPet
    {
        public string name;
        public int health;
        public int hunger;
        public int thirst;
        public int boredom;
        public int restless;
        public int tired;
        public int potty;
        public int end;

        //Default Constructor
        public VirtualPet()
        {
            this.name = "Bob";
            this.health = 100;
            this.hunger = 20;
            this.thirst = 20;
            this.boredom = 20;
            this.restless = 20;
            this.tired = tired = 20;
            this.potty = 20;
            this.end = 10;
        }

        public VirtualPet(string name, int health, int hunger, int thirst, int boredom, int restless, int tired, int potty, int end)
        {
            this.name = name;
            this.health = health;
            this.hunger = hunger;
            this.thirst = thirst;
            this.boredom = boredom;
            this.restless = restless;
            this.tired = tired;
            this.potty = potty;
            this.end = end;
        }

        /*Health:
         
         Increase your pet's health through regular checkup's when health is below 50!
         Vet visits cause a slight increase for all pet stats. 
        -Taking care of your pet also slows health decrease!*/

        public void HealthIncrease()
        {
            this.health = health + 55;
            this.hunger = hunger - 5;
            this.thirst = thirst - 5;
            this.boredom = boredom - 4;
            this.restless = restless - 4;
            this.tired = tired - 4;
            this.potty = potty - 4;
        }

        //Decrease the health:
        public void HealthDecrease()
        {
            this.health = health - 4;
        }


        //Hunger:

        //Increase the hunger:
        public void HungerIncrease()
        {
            this.hunger = hunger + 3;
        }

        //Meal Time! -Decreases Hunger and Thirst by giving pet food + water, but increases tiredness:
        public void Meal()
        {
            this.hunger = hunger - 6;
            this.thirst = thirst - 4;
            this.tired = tired + 2;
            this.potty = potty + 3;
            this.health = health + 2;
        }


        //Thirst:

        //Increase the thirst:
        public void ThirstIncrease()
        {
            this.thirst = thirst + 3;
        }

        //Give your pet water to decrease thirst! -Also helps slow the increase of your pet's hunger!:
        public void ThirstDecrease()
        {
            this.thirst = thirst - 6;
            this.hunger = hunger - 2;
            this.potty = potty + 2;
            this.health = health + 2;
        }


        //Boredom:

        //Increase boredom:
        public void BoredomIncrease()
        {
            this.boredom = boredom + 3;
        }



        //Play with your pet! Decreases Boredom and Restlessness, but increases thirst and tiredness.:
        public void BoredomDecrease()
        {
            this.boredom = boredom - 6;
            this.restless = restless - 4;
            this.thirst = thirst + 1;
            this.tired = tired + 1;
            this.health = health + 1;
        }

        public void OverlyBored()
        {
            this.boredom = boredom + 25;
            this.restless = restless - 5;
            this.thirst = thirst + 5;
            this.tired = tired + 5;
            this.health = health + 5;
        }



        //Restlessness:

        //Increase restlessness of pet:

        public void RestlessIncrease()
        {
            this.restless = restless + 3;
        }

        //Take your pet on a walk! Decreases restlessness and boredom of pet, but increases thirst and tiredness!:
        public void RestlessDecrease()
        {
            this.restless = restless - 6;
            this.boredom = boredom - 4;
            this.thirst = thirst + 2;
            this.tired = tired + 2;
            this.health = health + 2;
        }

        //Take your pet on an extra long walk! Decreases restlessness and boredom of pet, but increases thirst and tiredness!:
        public void OverlyRestless()
        {
            this.restless = restless + 25;
            this.boredom = boredom - 5;
            this.thirst = thirst + 5;
            this.tired = tired + 5;
            this.health = health + 5;
        }


        //Tiredness:

        //Increase tiredness of pet:
        public void TiredIncrease()
        {
            this.tired = tired + 3;
        }

        //Pet takes quick nap (35 and above)! Decreases tiredness, restlessness and boredom of pet, but increases hunger and thirst!:

        public void QuickNap()
        {
            this.tired = tired - 35;
            this.restless = restless - 5;
            this.boredom = boredom - 5;
            this.hunger = hunger + 5;
            this.thirst = thirst + 5;
            this.health = health + 5;
        }



        //Let your pet sleep (50 and above) Decreases tiredness, restlessness and boredom of pet, but increases hunger and thirst!:
        public void TiredDecrease()
        {
            this.tired = tired - 53;
            this.restless = restless - 20;
            this.boredom = boredom - 20;
            this.hunger = hunger + 10;
            this.thirst = thirst + 10;
            this.health = health + 15;
        }


        //Bathroom Needs:

        //Increase pets need to be let outside:

        public void PottyIncrease()
        {
            this.potty = potty + 3;
        }

        //Let your pet outside (50 and above)! Decreases pet's bathroom needs!:

        public void InAndOut()
        {
            this.potty = potty - 43;
        }


        public void PottyDecrease()
        {
            this.potty = potty - 55;
            this.health = health + 1;
        }



        //Stats of pet:

        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Boredom: " + boredom);
            Console.WriteLine("Restlessness: " + restless);
            Console.WriteLine("Tiredness: " + tired);
            Console.WriteLine("Bathroom: " + potty);
            Console.WriteLine("Health: " + health);



        }
    }
}
