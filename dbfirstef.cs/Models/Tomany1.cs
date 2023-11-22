using System;
using System.Collections.Generic;

namespace dbfirstef.Models
{
    public partial class Tomany1
    {
        public Tomany1()
        {
            Onesses = new HashSet<Oness>();
        }

        public int Id { get; set; }

        public virtual ICollection<Oness> Onesses { get; set; }
    }
}
