using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    //utlity class consists of only static functions Hence, the class need not to be instatntiated

    //i do not want the class not to be inhertied or instantaniated
    //ANS - mark the class as static class

    public class emputils
    {
        public static List<employee>empdb = new List<employee>();
        public static int empcount { get; set; }
        public static void Log<T>(T[] pValues)
        {
            string result = "";
            foreach (var item in pValues)
            {
                result = $"{result} {item}";
            }

            var finalResult = $"[ {DateTime.Now.ToString()} ] : {result}";
            //Console Logging
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------");
            Console.WriteLine(finalResult);

            //Output Window
            Debug.WriteLine("----- LOG ------");
            Debug.WriteLine(finalResult);

        }
        /*public static void logoutput()
        {

        }*/
    }
}
