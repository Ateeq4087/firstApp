// See https://aka.ms/new-console-template for more information
using TESTDAL;
using TestDbConsole;

Console.WriteLine("Hello, World!");
#region dbcontext
/*testDBcontetxt dbContext = new testDBcontetxt();
if (false)
{
    dbContext.parents.Add(new parent() { name = "seema", isActive = true });
    dbContext.SaveChanges();

    dbContext.children.Add(new child() { name = "varun", isActive = true });
    dbContext.SaveChanges();

}
*//*if (false)
{
    var tobeupdated = dbContext.parents.ToList().Where((parent) => parent.name == "seema").FirstOrDefault();
    tobeupdated.name = "Imposter";
    dbContext.SaveChanges();
}*//*
var tobeupdated = dbContext.parents.ToList().Where((parent) => parent.name == "Imposter").FirstOrDefault();
dbContext.parents.Remove(tobeupdated);
dbContext.SaveChanges();


dbContext.parents.ToList().ForEach((parent) =>
{
    if (parent.isActive == true)
        Console.WriteLine($"{parent.name} is an {parent.isActive} parent");
    else
        Console.WriteLine($"{parent.name} is a child");
});*/
#endregion dbcontext
/*Crudef<parent>.Add("Seema ", true);
Crudef<parent>.Add("Varun", false);
Crudef<parent>.Add("Imposter", false);

Crudef<parent>.Update("varun", "Bob marley");

Crudef<parent>.Add("Hacker", false);

Crudef<parent>.Delete("Bob marley");*/
var result = Crudef<parent>.SearchOne("seema");
Console.WriteLine($"Search match is:{result.name}");

Crudef<parent>.Get().ForEach((p) =>
{
    if (p.isActive == true)
        Console.WriteLine($"{p.name} is an {p.isActive} parent");
    else
        Console.WriteLine($"{p.name} is child");
});
//


