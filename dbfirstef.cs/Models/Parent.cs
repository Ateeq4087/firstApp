using System;
using System.Collections.Generic;

namespace dbfirstef.Models
{
    public partial class Parent
    {
        public int Parentkey { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public string Discriminator { get; set; } = null!;
        public DateTime? Birthdate { get; set; }
        public int? Age { get; set; }
        public string? Hobby { get; set; }
    }
}
