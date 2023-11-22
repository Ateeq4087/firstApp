using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    public class father
    {
        public virtual string settle()
        {
            return "Get a Govt job, Retire by age-60 and settle in native";
        }
        public string getmarried()
        {
            return "Accept the reality, abb se jo hai yahi hai,settle in joint family ";
        }

        public object drawing()
        {
            return "Drawing potraits,Tanjure Paintings";
        }

        public object whatisdating()
        {
            return "Meeting new girlfriend at resturant";
        }

        public abstract class talents
        {
            public abstract string whatisdating();
            public abstract string drawing();
        }
        public class Father : talents
        {
            public virtual string settle()
            {
                return "Get a Govt job, Retire by age-60 and settle in native";
            }
            public string getmarried()
            {
                return "Accept the reality, abb se jo hai yahi hai,settle in joint family";
            }
            public override string drawing()
            {
                return "Drawing potraits,Tanjure Paintings";
            }
            public override string whatisdating()
            {
                return "Meeting new girlfriend at resturant";
            }
           

        }

        
    }
    public class child : father
    {
        public override string settle()
        {
            string howtolive = " Get a good job, travel abroad and live unpredictable";
            howtolive = $"{howtolive} and later follow this {base.settle()}";
            return howtolive;
        }

        //function hiding
        new public string getmarried()
        {
            return " Register marriage,surprise parents and settle in abroad";
        }
    }
   
}
