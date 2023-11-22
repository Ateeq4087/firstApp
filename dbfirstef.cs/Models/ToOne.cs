using System;
using System.Collections.Generic;

namespace dbfirstef.Models
{
    public partial class ToOne
    {
        public int Id { get; set; }
        public int RelatedtoOneId { get; set; }

        public virtual Oness RelatedtoOne { get; set; } = null!;
    }
}
