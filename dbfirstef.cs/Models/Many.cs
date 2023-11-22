using System;
using System.Collections.Generic;

namespace dbfirstef.Models
{
    public partial class Many
    {
        public Many()
        {
            Tomany2s = new HashSet<Manytomany>();
        }

        public int Id { get; set; }

        public virtual ICollection<Manytomany> Tomany2s { get; set; }
    }
}
