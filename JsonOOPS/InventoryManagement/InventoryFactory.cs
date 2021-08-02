using System;
using System.Collections.Generic;
using System.Text;

namespace JsonOOPS.InventoryManagement
{
    class InventoryFactory
    {

        //operations on Rice data --------------------------------------------
        public List<RiceClass> AddToInventory(List<RiceClass> ricelist)
        {
            RiceClass rc = new RiceClass();

            Console.Write(" Enter Name : ");
            rc.Name = Console.ReadLine();
            string searchTerm = rc.Name;
            int newAdd = 1;
            foreach (RiceClass r in ricelist)
            {
                if ((r.Name).ToUpper().Equals(searchTerm.ToUpper()))
                {
                    Console.WriteLine(" New Name already present.");
                    newAdd = 0;
                    break;
                }
            }
            if (newAdd == 1)
            {
                Console.Write(" Enter price of 1kg : ");
                rc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight : ");
                rc.Weight = Convert.ToInt32(Console.ReadLine());
                ricelist.Add(rc);
                Console.WriteLine(" Added. ");
            }
            return ricelist;
        }

        public void DisplayInventory(List<RiceClass> ricelist)
        {
            string riceDisplay;

            foreach (RiceClass r in ricelist)
            {
                riceDisplay = " Name : " + r.Name + "\t Weight in kg : " + r.Weight + "\t Price : " + r.PricePerKg + "\t Total : "+(r.PricePerKg*r.Weight);
                Console.WriteLine(riceDisplay);
            }
        }

        public List<RiceClass> RemoveFromInventory(List<RiceClass> ricelist)
        {
            Console.Write(" Enter RiceName to be deleted : ");
            string searchTerm = Console.ReadLine();
            if (ricelist.Remove(ricelist.Find(term => term.Name.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.WriteLine(" {0} info Deleted. ",searchTerm);
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return ricelist;
        }

        public List<RiceClass> EditInventory(List<RiceClass> ricelist)
        {
            RiceClass rc = new RiceClass();

            Console.Write(" Enter name of rice to update : ");
            string searchTerm = Console.ReadLine();
            if (ricelist.Remove(ricelist.Find(term => term.Name.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.Write(" Enter Name : ");
                rc.Name = Console.ReadLine();
                Console.Write(" Enter price of 1kg : ");
                rc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight  : ");
                rc.Weight = Convert.ToInt32(Console.ReadLine());
                ricelist.Add(rc);
                Console.WriteLine(" Edit Success. ");
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return ricelist;
        }


        //operations on pulses data --------------------------------------------

        public List<PulsesClass> AddToInventory(List<PulsesClass> pulseslist)
        {
            PulsesClass pc = new PulsesClass();

            Console.Write(" Enter Name : ");
            pc.Name = Console.ReadLine();
            string searchTerm = pc.Name;
            int newAdd = 1;
            foreach (PulsesClass p in pulseslist)
            {
                if ((p.Name).ToUpper().Equals(searchTerm.ToUpper()))
                {
                    Console.WriteLine(" New Name already present.");
                    newAdd = 0;
                    break;
                }
            }
            if (newAdd == 1)
            {
                Console.Write(" Enter price of 1kg : ");
                pc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight : ");
                pc.Weight = Convert.ToInt32(Console.ReadLine());
                pulseslist.Add(pc);
                Console.WriteLine(" Added. ");
            }
            return pulseslist;
        }

        public void DisplayInventory(List<PulsesClass> pulseslist)
        {
            string pulsesDisplay = string.Empty;

            foreach (PulsesClass r in pulseslist)
            {
                pulsesDisplay = " Name : " + r.Name + "\t Weight in kg : " + r.Weight + "\t Price : " + r.PricePerKg + "\t Total : " + (r.PricePerKg * r.Weight);
                Console.WriteLine(pulsesDisplay);
            }
        }

        public List<PulsesClass> EditInventory(List<PulsesClass> pulseslist)
        {
            PulsesClass rc = new PulsesClass();

            Console.Write(" Enter PulsesName to update : ");
            string searchTerm = Console.ReadLine();
            if (pulseslist.Remove(pulseslist.Find(term => term.Name.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.Write(" Enter Name : ");
                rc.Name = Console.ReadLine();
                Console.Write(" Enter price of 1kg : ");
                rc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight  : ");
                rc.Weight = Convert.ToInt32(Console.ReadLine());
                pulseslist.Add(rc);
                Console.WriteLine(" Edit Success. ");
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return pulseslist;
        }

        public List<PulsesClass> RemoveFromInventory(List<PulsesClass> pulseslist)
        {
            Console.Write(" Enter PulsesName to be deleted : ");
            string searchTerm = Console.ReadLine();
            if (pulseslist.Remove(pulseslist.Find(term => term.Name.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.WriteLine(" {0} info Deleted. ", searchTerm);
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return pulseslist;
        }


        //operations on wheat data --------------------------------------------
        
        public List<WheatClass> AddToInventory(List<WheatClass> wheatlist)
        {
            WheatClass wc = new WheatClass();

            Console.Write(" Enter Name : ");
            wc.Name = Console.ReadLine();
            string searchTerm = wc.Name;
            int newAdd = 1;
            foreach (WheatClass p in wheatlist)
            {
                if ((p.Name).ToUpper().Equals(searchTerm.ToUpper()))
                {
                    Console.WriteLine(" New Name already present.");
                    newAdd = 0;
                    break;
                }
            }
            if (newAdd == 1)
            {
                Console.Write(" Enter price of 1kg : ");
                wc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight : ");
                wc.Weight = Convert.ToInt32(Console.ReadLine());
                wheatlist.Add(wc);
                Console.WriteLine(" Added. ");
            }
            return wheatlist;
        }

        public void DisplayInventory(List<WheatClass> wheatlist)
        {
            string wheatDisplay;

            foreach (WheatClass w in wheatlist)
            {
                wheatDisplay = " Name : " + w.Name + "\t Weight in kg : " + w.Weight + "\t Price : " + w.PricePerKg + "\t Total : " + (w.PricePerKg * w.Weight);
                Console.WriteLine(wheatDisplay);
            }
        }

        public List<WheatClass> EditInventory(List<WheatClass> wheatlist)
        {
            WheatClass wc = new WheatClass();

            Console.Write(" Enter WheatName to update : ");
            string searchTerm = Console.ReadLine();
            if (wheatlist.Remove(wheatlist.Find(term => term.Name.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.Write(" Enter Name : ");
                wc.Name = Console.ReadLine();
                Console.Write(" Enter price of 1kg : ");
                wc.PricePerKg = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Enter Weight  : ");
                wc.Weight = Convert.ToInt32(Console.ReadLine());
                wheatlist.Add(wc);
                Console.WriteLine(" Edit Success. ");
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return wheatlist;
        }

        public List<WheatClass> RemoveFromInventory(List<WheatClass> wheatlist)
        {
            Console.Write(" Enter WheatName to be deleted : ");
            string searchTerm = Console.ReadLine();
            if (wheatlist.Remove(wheatlist.Find(term => term.Name.ToUpper().Equals(searchTerm.ToUpper()))))
            {
                Console.WriteLine(" {0} info Deleted. ", searchTerm);
            }
            else
            {
                Console.WriteLine(" Search term not matched.");
            }
            return wheatlist;
        }

    }
}
