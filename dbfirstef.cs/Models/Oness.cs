using System;
using System.Collections.Generic;

namespace dbfirstef.Models
{
    public partial class Oness
    {
        public Oness()
        {
            ToOnes = new HashSet<ToOne>();
        }

        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int? Tomany1id { get; set; }

        public virtual Tomany1? Tomany1 { get; set; }
        public virtual ICollection<ToOne> ToOnes { get; set; }
    }
}
