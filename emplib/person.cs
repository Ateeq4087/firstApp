using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    public enum Gender
    {
        male,female
    }
    
    public class person 
    {
        public person()
        {

        }
        public person(string pAadhaar)
        {
            this.Aadhaar = pAadhaar;
        }
        public person(string pAadhaar,string pphone):this(pAadhaar)
        {
            this.Phone=pphone;
        }
        public string Name { get; set; }
        public string Aadhaar { get; set; }
        public string Email { get; set; }
        public string personGender { get; set; }
        public DateTime Address { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }

        public string eat()
        {
            return $"{this.Name} Eats Breakfast Lunch and Dinner";
        }
        public string sleep()
        {
            return $"{this.Name} Sleeps for 8hrs a day";
        }
        public virtual string work()
        {
            return $"{this.Name} Works for 4hrs,Relaxes for 8hrs";
        }
        protected string taxdetails { get; set; }
    }

}
