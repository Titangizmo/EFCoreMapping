using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class ASSActiviteit
    {
        // ----------
        // Properties
        // ----------
        public int ActiviteitId { get; set; }
        public string Naam { get; set; }
        // ---------------------
        // Navigation properties
        // ---------------------
        public virtual ICollection<ASSDocentActiviteit> DocentenActiviteiten { get; set; } = new
List<ASSDocentActiviteit>();
    }
}
