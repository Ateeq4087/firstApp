// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
Method1();
Method2();
void Method1()
{
    for (int i = 0;i<1000;i++)
    {
        Console.WriteLine($"i={i}");
    }
}

void Method2()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"Method 2 : i={i}");
    }
}*/
await simpletask();
File.WriteAllText(@"somefile.txt", "\tThis is text file for checking the execution");
string contents = await Readfile(); 
Console.WriteLine(contents);

async Task simpletask()
{
    Console.WriteLine("Starting of the task");
     await Task.Delay(5000);
    Console.WriteLine("Task Complete");
}

async Task<string> Readfile()
{
    using (StreamReader r =new StreamReader(@"somefile.txt"))
    {
        return await r.ReadToEndAsync();
    }
}