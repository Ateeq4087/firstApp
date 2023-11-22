using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LABDAL
{
    public class labclass
    {
        public class student
        {
            [Key]
            public int student_Id { get; set; }
            public string course { get; set; }
        }
        public class course
        {
            [Key]
            public int course_id { get; set; }
            public string course_name { get; set; }
        }
        public class company
        {
            [Key]
            public int company_id { get; set; }
            public string company_name { get; set; }
            public student relatedto_student { get; set; }
        }
        public class tomanycourse
        {
            [Key]
            public int course_id { get; set; }
            public List<student> Toomanycourses { get; set; }
        }
        public class tomanystudents
        {
            [Key]
            public int student_id { get; set; }
            public List<course> Toomanystudents { get; set; }
        }

        public class LabDBcontetxt : DbContext
        {
            public DbSet<student> students { get; set; }
            public DbSet<course> courses { get; set; }
            public DbSet<tomanycourse> tomanycourses1 { get; set; }
            public DbSet<tomanystudents> tomanystudents1 { get; set; }
            public DbSet<company> companies { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=labdb;Trusted_Connection=True");
            }
        }

    }
}
