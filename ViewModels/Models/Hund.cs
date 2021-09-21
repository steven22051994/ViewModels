using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModels.Models
{
    [Serializable]
    public class Hund
    {
        public int Id { get; set; }
        public int Age { get; set; } = 0;
        public string Name { get; set; } = "";
        public double Beine { get; set; } = 4.0;
        // Fremdschlüssel für die Felle
        public int FellId { get; set; } = -1;
        public bool Active { get; set; } = true;
        
        public Hund()
        {

        }

    }


    public class Fell
    {
        public int Id { get; set; }
        public FarbeEnum  Farbe { get; set; }
        public bool Active { get; set; } = true;

    }

    public enum FarbeEnum
    {
        braun,
        schwarz,
        orange,
        andere
    }
}