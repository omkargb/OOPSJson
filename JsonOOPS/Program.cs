using JsonOOPS.InventoryManagement;
using System;

namespace JsonOOPS
{
    class Program
    {
        const string INVENTORY_JSON = @"G:\BRIDGELABZ\OOPSJson\JsonOOPS\InventoryManagement\Inventory.json";
        public static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Json Inventory management program ");
            InventoryMain inv = new InventoryMain();
            inv.ShowOptions(INVENTORY_JSON);
        }
    }
}
