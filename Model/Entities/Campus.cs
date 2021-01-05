using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Campus
    {
        // ----------
        // Properties
        // ----------
        public int CampusId { get; set; }
        public string Naam { get; set; }
        
        public virtual Adres Adres { get; set; }
        public string Commentaar { get; set; }
        // ---------------------
        // Navigation Properties
        // ---------------------
        public virtual ICollection<Docent> Docenten { get; set; } = new List<Docent>();
    }
}
