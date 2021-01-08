using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
   public  class ASSCursus
    {
        // ----------
        // Properties
        // ----------
        public int CursusId { get; set; }
        public string Naam { get; set; }
        // -----------
        // Associaties
        // -----------
        public virtual ICollection<ASSBoekCursus> BoekenCursussen { get; set; } = new
        List<ASSBoekCursus>();
    }
}
