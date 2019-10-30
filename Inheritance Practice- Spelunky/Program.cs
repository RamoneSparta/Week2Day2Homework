using System;

namespace Inheritance_Practice__Spelunky
{
    class Player 
    {
        private int health;
        private bool isHoldingWeapon;
        private int ropes;
        private int bombs;

    }
    class Items
    { 
        private int equipAmount;
    }
    class Enemies 
    { 
        private int health;
        private int damage;
        private string heldItem;
        private bool canFly;
        public bool isHostile;
    }
    class Levels
    {
        public string entrance;
        public string exit;
        public string damsel;
        public bool isShopAvaliable;
        public bool isVaultAvaliable;
        public bool isSecretLevelEntrance;

    }
    class Shopkeeper: Enemies
    {
        public bool isThrowPlayer;
    }

    class Cavemen : Enemies
    {
        public bool isRunning;
    }

    class Weapons : Items
    {
        private int damage;
    }

    class Powerups : Items
    {
        public string effect;
    }

    class Mines : Levels
    {
        public string minecart;
    }

    class Jungle : Levels
    {
        public string vines;
    }

    class Icecaves : Levels
    {
        public string icicles;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            MethodExample methodExample = new MethodExample();
            string myString = methodExample.ReverseString("Please reverse me");
            // ^Assignment opporator
            Console.WriteLine(myString);
        }
    }

    class MethodExample 
    {
        // Every method has an access specifier, return type
        // It also has a name and arguments if needed and finally a body

        public string ReverseString(string str) 
        {

            return "string has been reversed";
        }
    }
}

namespace Spelunky_Game
{
    using Inheritance_Practice__Spelunky;

    class program
    {
        Player adventurer = new Player();
        Mines firstLevel = new Mines();
        Weapons Shotgun = new Weapons();
        Shopkeeper shopkeeper = new Shopkeeper();
    }


}
