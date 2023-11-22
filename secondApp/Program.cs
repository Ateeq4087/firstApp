using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        workingwithdatatypes();
        void workingwithdatatypes()
        {
            Console.WriteLine("\n\tHello, User! learn c# , Output is not more than this please move to next--->\n");
            Console.WriteLine("\nAdd this numbers: " + (3 + 3));

            int num1 = 100;
            int num2 = 100;
            Console.WriteLine("sum = : " + (num1 + num2));

            var num3 = 200;
            var formattedfloat = 200;
            var formatteddouble = 200;
            var formatteddecimal = 200;
            Console.WriteLine(num3.GetType().Name);
            Console.WriteLine(formattedfloat.GetType().Name);
            Console.WriteLine(formatteddouble.GetType().Name);
            Console.WriteLine(formatteddecimal.GetType().Name);

            Console.WriteLine($"The datatype of num is {num3.GetType().Name}");

            bool isEverythingOK = true;
            string greetMessage = "Hello welcome to C# Training Session in kpmg";
            char iamsingle = 'S';

            Console.WriteLine($"Value of {nameof(isEverythingOK)} is {isEverythingOK}");

        }

        conversionofTypes();
        void conversionofTypes()
        {
            int num1 = 100;
            double num2 = 100;
            //bool isEverythingOK = true;
            string str = "hello";

            var result1 = (double)num1;
            var result2 = (int)num2;
            //var result3 = (int)isEverythingOK;---string on heap 6 and bool on stack and hence error in cast
            var convert1 = Convert.ToString(num1);
            var convert2 = Convert.ToInt32(num2);
            //var convert3 = Convert.ToInt32(str);

        }

        workingwithArrays();
        void workingwithArrays()
        {
            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Value of i :{arr[i]}");
            }

            string[] greetings = { "Namaste", "Hello", "Adaab", "Hola" };
            int counter = 0;

            while (counter < greetings.Length)
            {
                Console.WriteLine($"A new way to Greet:{greetings[counter]} ");
                counter++;
            }
            int[] evens = { 2, 4, 6, 8, 10 };
            counter = 0;
            do
            {
                Console.WriteLine($"The Next Even Number : {evens[counter]}");
                counter++;
            }
            while (counter < evens.Length);
            object[] objarray = { 100, "OK", new int[] { 1, 2, 3, 4, } };

            foreach (var singleitem in objarray)
            {
                if (singleitem.GetType().Name == "Int32[]")
                {
                    foreach (var item in (int[])singleitem)
                    {
                        Console.WriteLine(item);
                    }
                }

            }

        }

        workingwithlists();
        void workingwithlists()
        {
            List<string> shoppinglist = new List<string>();
            Console.WriteLine($"Total items in shopping Bag : {shoppinglist.Count()}");
            shoppinglist.Add("snacks");
            shoppinglist.Add("Books");
            shoppinglist.Add("Clothes");
            shoppinglist.Add("Vegetables");
            Console.WriteLine($"Total items in shopping Bag : {shoppinglist.Count()}");
            shoppinglist.Add("furniture");
            shoppinglist.Add("stationary");
            shoppinglist.Add("cutlery");
            //print
            printvalues(shoppinglist);
            Console.WriteLine($"Total items in shopping Bag : {shoppinglist.Count()}");
            shoppinglist.Remove("snacks");
            Console.WriteLine($"Total items in shopping Bag : {shoppinglist.Count()}");

            Print(new object[] {"comma seperated values of the shopping list",
            shoppinglist[0],
            shoppinglist[1],
            "\n the total number of item is : " ,shoppinglist.Count()});
        }
        
        void printvalues<T> (List<T> pCollection)
            {
            foreach(var item in (pCollection))
            {
                Console.WriteLine(item);
            }
         }

        void log(object[] pvalues)
        {
            string result = "";
            foreach (var item in pvalues)
            {
                result = $"{result},{item}";
            }
            var finalresult = $"[{DateTime.Now.ToString()} ] : {result}";
            //console logging 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------");
            Console.WriteLine(finalresult);

            //output Window
            Debug.WriteLine("-----LOG-----");
            Debug.WriteLine(finalresult);
        }
        void Print<T>(T[] pValues)
        {
            string result = "";
            foreach (var item in pValues)
            {
                result = $"{result},{item}";
            }
            result = result.TrimStart(',');
            Console.WriteLine(result);
        }
    }

    
}



    



