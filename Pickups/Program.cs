using System;

namespace Pickups
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // base class
    class InventoryItem
    {
        bool HitByMouse(float x, float y)
        {
            return false;
        }
    }

    // inherited base class 
    class InventoryUseable : InventoryItem
    {
        void Consume()
        {
            // consumes item
        }
    }

    class InventoryEquipable : InventoryItem
    {
        void Equip()
        {
            // equips item
        }
    }

    // inherited classes 
    class Money : InventoryItem
    {
        int currentMoney;
        int OnPickup(int amount)
        {
            this.currentMoney += amount;
            return currentMoney;
        }
    }

    class HealthPotion : InventoryUseable
    {

    }

    class PoisonCure : InventoryUseable
    {

    }

    class Weapon : InventoryEquipable
    {

    }

    class Armor : InventoryEquipable
    {

    }
}
