using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
   public class Personeelslid
    {
        public int PersoneelsId { get; set; }
        public string Voornaam { get; set; }
        public int? ManagerId { get; set; }

        // ---------------------
        // Navigation Properties
        // ---------------------

        public virtual ICollection<Personeelslid> Personeel { get; set; } = new List<Personeelslid>();
        public virtual Personeelslid Manager { get; set; }
    }
}
