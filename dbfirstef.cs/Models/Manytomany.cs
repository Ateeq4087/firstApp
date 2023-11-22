using System;
using System.Collections.Generic;

namespace dbfirstef.Models
{
    public partial class Manytomany
    {
        public Manytomany()
        {
            Manys = new HashSet<Many>();
        }

        public int Id { get; set; }

        public virtual ICollection<Many> Manys { get; set; }
    }
}
