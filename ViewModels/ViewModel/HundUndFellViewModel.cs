using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModel
{
    public class HundUndFellViewModel
    {
        public Hund Hundreferenz { get; set; }
        public Fell Fellreferenz { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}