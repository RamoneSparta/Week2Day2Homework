using System;

namespace Inheritance_Practice__Spelunky
{
    class Player
    {
        private int health = 4;
        private bool isHoldingWeapon = false;
        private int ropes = 4;
        private int bombs = 4;

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int value)
        {
            if (value > 99)
            {
                health = 99;
            }
            else
            {
                health = value;
            }
        }
        public bool getIsHoldingWeapon()
        {
            return isHoldingWeapon;
        }
        public void setIsHoldingWeapon(bool value)
        {
            isHoldingWeapon = value;
        }
        public int getRopes()
        {
            return ropes;
        }
        public void setRopes(int value)
        {
            if (value > 99)
            {
                ropes = 99;
            }
            else
            {
                ropes = value;
            }

        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is the Player");
        }

        public int getBombs()
        {
            return bombs;
        }
        public void setBombs(int value)
        {
            if (value > 99)
            {
                bombs = 99;
            }
            else
            {
                bombs = value;
            }
        }
    }


    class Items
    {
        private int equipAmount = 1;

        public int getEquipAmount()
        {
            return equipAmount;
        }

        public void setEquipAmount(int value)
        {
            if (value > 99)
            {
                equipAmount = 99;
            }
            else
            {
                equipAmount = value;
            }
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is a Item");
        }
    }


    class Enemies
    {
        private int health;
        private int damage;
        private string heldItem;
        private bool canFly;
        private bool isHostile;

        public int getHealth()
        {
            return health;
        }

        public void setHealth(int value)
        {
            health = value;
        }

        private int getDamage()
        {
            return damage;
        }

        private void setDamage(int value)
        {
            damage = value;
        }

        private string getHeldItem()
        {
            return heldItem;
        }

        private void setHeldItem(string value)
        {
            heldItem = value;
        }

        private bool getCanFly()
        {
            return canFly;
        }

        private void setCanFly(bool value)
        {
            canFly = value;
        }

        private bool getIsHostile()
        {
            return isHostile;
        }

        private void setIsHostile(bool value)
        {
            isHostile = value;
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is a Enemy");
        }
    }
    class Levels
    {
        private string entrance;
        private string exit;
        private string damsel;
        private bool isShopAvaliable;
        private bool isVaultAvaliable;
        private bool isSecretLevelEntrance;

        public string getEntrance()
        {
            return entrance;
        }

        public void setEntrance(string value)
        {
            entrance = value;
        }

        public string getExit()
        {
            return exit;
        }

        public void setExit(string value)
        {
            exit = value;
        }

        public string getDamsel()
        {
            return damsel;
        }

        public void setDamesel(string value)
        {
            damsel = value;
        }

        public bool getIsShopAvaliable()
        {
            return isShopAvaliable;
        }

        public void setIsShopAvaliable(bool value)
        {
            isShopAvaliable = value;
        }

        public bool getIsVaultAvaliable()
        {
            return isVaultAvaliable;
        }

        public void setIsVaultAvaliable(bool value)
        {
            isVaultAvaliable = value;
        }

        public bool getIsSecretLevelEntrance()
        {
            return isSecretLevelEntrance;
        }

        public void setIsSecretLevelEntrance(bool value)
        {
            isSecretLevelEntrance = value;
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This a Level");
        }
    }
    class Shopkeeper : Enemies
    {
        private bool isThrowPlayer;

        public bool getIsThrowPlayer()
        {
            return isThrowPlayer;
        }

        public void setIsThrowPlayer(bool value)
        {
            isThrowPlayer = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Shopkeeper");
        }
    }

    class Cavemen : Enemies
    {
        private bool isRunning;

        public bool getIsRunning()
        {
            return isRunning;
        }

        public void setIsRunning(bool value)
        {
            isRunning = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Caveman");
        }

    }

    class Weapons : Items
    {
        private int damage;

        public int getDamage()
        {
            return damage;
        }

        public void setDamage(int value)
        {
            damage = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Weapon");
        }
    }

    class Powerups : Items
    {
        private string effect;

        public string getEffect()
        {
            return effect;
        }

        public void setEffect(string value)
        {
            effect = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is a Powerup");
        }
    }

    class Mines : Levels
    {
        private string minecart;

        public string getMinecart()
        {
            return minecart;
        }
        public void setMinecart(string value)
        {
            minecart = value;
        }

        public virtual void PrintMethod()
        {
            Console.WriteLine("This is Mines");
        }
    }

    class Jungle : Levels
    {
        private string vines;

        public string getVines()
        {
            return vines;
        }

        public void setVines(string value)
        {
            vines = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is the Jungle Level");
        }
    }

    class Icecaves : Levels
    {
        private string icicles;

        public string getIcicles()
        {
            return icicles;
        }

        public void setIcicles(string value)
        {
            icicles = value;
        }

        public override void PrintMethod()
        {
            Console.WriteLine("This is the Icecave Level");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();
            //MethodExample methodExample = new MethodExample();
            //string myString = methodExample.ReverseString("Please reverse me");
            //// ^Assignment opporator
            //Console.WriteLine(myString);

            Player adventurer = new Player();
            Mines firstLevel = new Mines();
            Weapons Shotgun = new Weapons();
            Shopkeeper shopkeeper = new Shopkeeper();

        }
    }

    //class MethodExample 
    //{
    //    // Every method has an access specifier, return type
    //    // It also has a name and arguments if needed and finally a body

    //    public string ReverseString(string str) 
    //    {

    //        return "string has been reversed";
    //    }
    //}
}

//namespace Spelunky_Game
//{
//    using Inheritance_Practice__Spelunky;

//    class program
//    {
//        Player adventurer = new Player();
//        Mines firstLevel = new Mines();
//        Weapons Shotgun = new Weapons();
//        Shopkeeper shopkeeper = new Shopkeeper();
//    }


//}
