using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungTruckExample.ViewModel
{
    class LoadVM
    {
        public string Description { get; set; }
        public int Amount { get; set; }
        public int Weight { get; set; }

        public LoadVM(string description, int amount, int weight)
        {
            Description = description;
            Amount = amount;
            Weight = weight;
        }
    }
}
