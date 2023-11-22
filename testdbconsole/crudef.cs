
using TESTDAL;

namespace TestDbConsole
{
    public class Crudef<T> where T : parent
    {
        static testDBcontetxt dbContext = new testDBcontetxt();
        public static void Add(string pNmae, bool pIsActive)
        {
            dbContext.parents.Add(new parent() { name = pNmae, isActive = pIsActive });
            dbContext.SaveChanges();
        }

        public static void Update(string pName, string pUpdatedValue)
        {
            var tobeupdated = dbContext.parents
           .ToList()
           .Where((p) => p.name == pName)
           .FirstOrDefault();

            tobeupdated.name = pUpdatedValue;
            dbContext.SaveChanges();
        }

        public static List<T> Get()
        {

            dbContext.parents
                     .ToList()
                     .ForEach((p) =>
                     {
                         if (p.isActive == true)
                             Console.WriteLine($"{p.name} is an {p.isActive} parent");
                         else
                             Console.WriteLine($"{p.name} is child");
                     });
            return dbContext.parents.ToList() as List<T>;

        }




        public static T SearchOne(string pName)
        {
            var result = dbContext.parents
                .ToList()
                .Where(p => p.name == pName)
                .FirstOrDefault();
            return result as T;
        }
        public static void Delete(string pName)
        {
            var tobedeleted = dbContext.parents
        .ToList()
        .Where((p) => p.name == pName)
        .FirstOrDefault();
            dbContext.parents.Remove(tobedeleted);
            dbContext.SaveChanges();
        }
    }
}