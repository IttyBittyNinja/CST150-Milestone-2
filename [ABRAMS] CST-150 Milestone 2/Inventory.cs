using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _ABRAMS__CST_150_Milestone_2
{
    internal class Inventory

    {
        // Constructor
        public Inventory()
        {
            Code = 0;
            Name = "";
            Cost = 0;
            Quantity = 0;
            Category = "";
        }

        // Code property
        public int Code{ get; set; }

        // Name property
        public string Name { get; set; }

        // Cost property
        public int Cost { get; set; }

        // Quantity property
        public int Quantity { get; set; }

        // Category property
        public string Category { get; set; }

    }
}
