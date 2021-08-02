using System;
using System.Collections.Generic;
using System.Text;

namespace JsonOOPS.InventoryManagement
{
    public class InventoryModel
    {
        public List<RiceClass> RiceList { get; set; }
        public List<WheatClass> WheatList { get; set; }
        public List<PulsesClass> PulsesList { get; set; }

        //public String Name { get; set; }
        //public double Weight { get; set; }
        //public double PricePerKg { get; set; }
    }
}
