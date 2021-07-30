using JsonOOPS.InventoryManagement;
using System;

namespace JsonOOPS
{
    class Program
    {
        const string INVENTORY_JSON =@"C:\Users\HP\source\repos\JsonOOPS\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to json program");
            InventoryMain inv = new InventoryMain();
            inv.Displaydata(INVENTORY_JSON);
        }
    }
}
