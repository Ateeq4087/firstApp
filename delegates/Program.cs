// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;
partial class program
{
    //declaration = new dataypes
   // delegate void Compute(int n1, int n2);
   // delegate void contractor(double budget);
    delegate void work(string str);


    /*LAB 9 - Delegates Lab
Work Delegate: accepts string, bool and returns void
Work("Coding in C#", true)

Print Delegate: accepts a string and Returns a string to be printed
Print("Dhanush")

UpdateDb Delegate: accepts a string and returns boolean
UpdateDb("update Employee set isActive=true")*/

    static void Main()
    {
        Action<string, bool> work = new((str, bol) => { Console.WriteLine($"Coding ic {str},{bol}"); });
        work("c#", true);
        Func<string, string> printdeligate = new((str1) => $"{str1}");
        Console.WriteLine(printdeligate("Hi i'm Ateeq"));
        Predicate<string> updateDB = ((v) => v.Length != 0 || v == null ? true : false);
        Console.WriteLine($"Update employee set isActive :{updateDB("Hii")}");

    }
    

    /*static void Main()
    {
        rockyranimarriagedeligate();

        Action<double> rockyraniregistermarriage = new Action<double>((budget) =>
        {
            Console.WriteLine($" Registration fees :{budget * 95 / 100}");
            Console.WriteLine($"Reception charges : {budget * 5 / 100}");
        }
        );
        Func<int, int, string> modifiedcompute = (n1, n2) => $"Addition: {n1 + n2}";
        modifiedcompute += (n1, n2) => $"Subtraction: {n1 - n2}";
        modifiedcompute += (n1, n2) => $"multiplication: {n1 * n2}";
        modifiedcompute += (n1, n2) => $"division: {n1 / n2}";

        Predicate<int> isactive = (v) =>
        {
            if (v == 0) return false;
            else return true;
        };
        rockyraniregistermarriage(80000d);
        Console.WriteLine(modifiedcompute(200, 50));
        Console.WriteLine($"Output of predicate:{isactive(1)}");


    }

    private static void rockyranimarriagedeligate()
    {
        contractor rockyranimarriage = new contractor((b) => Console.WriteLine($"Pandit charges: {b + 20 / 100}"));
        rockyranimarriage += (b) => Console.WriteLine($"Catering charges: {b * 50 / 100}");
        rockyranimarriage += (b) => Console.WriteLine($"Decoration:{b * 5 / 100}");
        rockyranimarriage += (b) => Console.WriteLine($"couple entry:{b * 7 / 100}");

      *//*  rockyranimarriage(500000);
    }*/


  /* // private static void Main()
    {
        // Delegatesusinglongtechnique();
        //usinglamdas();

    }*/

    /*private static void usinglamdas()
    {
        Compute objshortcompute = new Compute((a, b) => Console.WriteLine($"Addition={a + b}"));
        objshortcompute += new Compute((x, y) => Console.WriteLine($"multiplication={x * y}"));
        objshortcompute += new Compute((m, n) => Console.WriteLine($"subtraction={m - n}"));
        objshortcompute += new Compute((p, q) => Console.WriteLine($"division={p / q}"));
        objshortcompute(200, 50);
    }
    private static void Delegatesusinglongtechnique()
    {

        //instantiated
        Compute objcompute = new Compute(Addfn);
        objcompute += subfn;
        objcompute += mulfn;
        objcompute += divfn;
        Console.WriteLine("Hello, welcome to delegates\n");

        //Invoke the delegate exactly like a function
        objcompute(100, 200);

    }

    static void Addfn(int n1, int n2)
    {
        Console.WriteLine($"output of addition :{n1 + n2}");
    }
    static void subfn(int n1, int n2)
    {
        Console.WriteLine($"output of subtraction :{n1 - n2}");

    }
    static void mulfn(int n1, int n2)
    {
        Console.WriteLine($"output of multiplication :{n1 * n2}");
    }
    static void divfn(int n1, int n2)
    {
        Console.WriteLine($"output of division :{n1 / n2}");
    }*/


}

