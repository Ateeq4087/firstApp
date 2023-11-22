using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TESTDAL
{
    #region Inheritance
    public class parent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int parentkey { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        public bool isActive { get; set; }
    }
    public class child :parent 
    {
        [NotMapped]
        public int childid { get; set;}
        public DateTime Birthdate { get; set; }
        [Range(18,100)]
        public int Age { get; set; }            

    }
    public class child2 : parent
    {
        public string name { get; set; }
        public string hobby { get; set; }
    }
    #endregion Iheritance
    

    public class one
    {
        public int Id { get; set; }
        public string value { get; set; }
    }
    public class to_one
    {
        [Key]
        public int Id { get; set; }
        public one relatedto_one { get; set; }
    }
    public class tomany1
    {
        public int id { get; set; }
        public List<one>  ToomanyOnes { get; set; }
    }
    public class many 
    {
        [Key]
        public int id { get; set; }
        public List<manytomany> tomany2s { get; set; }
    }
    public class manytomany
    {
        [Key]
        public int id { get; set; }
        public List<many> manys { get; set; }
    }
    public class testDBcontetxt:DbContext
    {
        [Key]
        public DbSet<parent> parents { get; set; }
        public DbSet<child> children { get; set; }
        public DbSet<child2> children2 { get; set; }
        public DbSet<one> oness { get; set; }
        public DbSet<to_one> to_Ones { get; set; }
        public DbSet<tomany1> tomany1s { get; set; }
        public DbSet<manytomany> manytomanys { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

         optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=testdb;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<parent>().Property(parent=>parent.parentkey).UseIdentityColumn();
            modelBuilder.Entity<parent>().HasOne<child>();
            modelBuilder.Entity<one>().HasMany<many>();
            modelBuilder.Entity<parent>().HasOne<parent>();
        }


    }
}