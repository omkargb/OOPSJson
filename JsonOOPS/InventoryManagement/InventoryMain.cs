using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonOOPS.InventoryManagement
{
    public class InventoryMain
    {
        public void Displaydata(string filePath)
        {

            try
            {
                using (StreamReader read = new StreamReader(filePath))
                {
                    var json = read.ReadToEnd();

                    var items = JsonConvert.DeserializeObject<List<InventoryModal>>(json);

                    Console.WriteLine(" Name\tWeight\tRate\tAmount");

                    foreach (var item in items)
                    {
                        Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t", item.Name, item.Weight, item.PricePerKg, item.Weight*item.PricePerKg);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
