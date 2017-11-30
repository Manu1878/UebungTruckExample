using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungTruckExample.ViewModel
{
    class TruckVM : ViewModelBase
    {
        public String Id { get; set; }
        public String Source { get; set; }
        public ObservableCollection<LoadVM> Loads { get; set; }

        public int TotalWeight;

        public TruckVM(string id, string source, ObservableCollection<LoadVM> loads)
        {
            Id = id;
            Source = source;
            Loads = loads;
        }

        public override string ToString()
        {
            return "ID: " + Id + "from: " + Source;
        }
    }
}
