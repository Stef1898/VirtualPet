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
        private int hunger;
        private int thirst;
        public int health;
        private int boredom;

        //Default Constructor
        public VirtualPet()
        {
            this.name = "Bob";
            this.hunger = 20;
            this.thirst = 20;
            this.boredom = 20;
            this.health = 100;
            //TODO account for more fields
        }

        public VirtualPet(string name, int hunger, int thirst, int health, int sick, int boredom)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;
            this.health = health;
            this.boredom = boredom;
        }

        //Increase the hunger
        public void HungerIncrease()
        {
            //Modify the values
            this.hunger = hunger + 3;
        }

        //Decrease the hunger
        public void HungerDecrease()
        {
            //Modify the values
            this.hunger = hunger - 5;
        }

        //Increase the thirst
        public void ThirstIncrease()
        {
            //Modify the values
            this.thirst = thirst + 3;
        }

        //Decrease the thirst
        public void ThirstDecrease()
        {
            //Modify the values
            this.thirst = thirst - 5;
        }

        //Increase the health
        public void HealthIncrease()
        {
            //Modify the values
            this.health = health + 65;
        }

        //Decrease the health
        public void HealthDecrease()
        {
            //Modify the values
            this.health = health - 3;
        }

        //Increase boredom
        public void BoredomIncrease()
        {
            //Modify the values
            this.boredom = boredom + 3;
        }

        //Decrease boredom
        public void BoredomDecrease()
        {
            //Modify the values
            this.boredom = boredom - 5;
        }


       


        //Stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Boredom: " + boredom);


        }
    }
}
