using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace empsysef
{
    public class employee1
    {
        [Key]
        public int empId { get; set; }
        [Required]
        public string empname { get; set; }
        public string address {  get; set; }
        public int ph_no { get; set; }

    }
    /*public class empoperations
    {
        static List<employee1> _emp = new List<employee1>();
        public static List<employee1> getpeople()
        {
            if (_emp.Count == 0)
            {

                _emp.Add(new employee1() { empId = 23, empname = "ateeq", address = "banglore", ph_no = 3433233 });
                _emp.Add(new employee1() { empId = 31, empname = "rushab", address = "manglore", ph_no = 8933233 });
                _emp.Add(new employee1() { empId = 45, empname = "kanishq", address = "Sanglore", ph_no = 2333233 });
            }
            return _emp;
        }
    }*/


        public class testempDB : DbContext
    {
        [Key]
        public DbSet<employee1 > emp_id { get; set; }
        public DbSet<employee1> empname { get; set; }

        public DbSet<employee1> ph_no { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=empDB;Trusted_Connection=True");
        }
       
    }
    
}