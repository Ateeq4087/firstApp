using System.ComponentModel.DataAnnotations;

namespace samplewebapp.Models
{
    public class personn
    {
        [Required]
        public string Aadhaar { get; set; }
        [MaxLength(1000)]
        public string name {  get; set; }
        [Range(10,110)]
        public int age { get; set; }
        [EmailAddress]
        public string email {  get; set; }
    }
    public class personnoperations
    {
        static List<personn> _people =new List<personn>();
        public static List<personn> getpeople()
        {
            if (_people.Count == 0)
            {

                _people.Add(new personn() { name = "ateeq", age = 22, Aadhaar = "AA12345", email = "ateeq@gmail.com" });
                _people.Add(new personn() { name = "rahaman", age = 21, Aadhaar = "AA34342", email = "rahaman@gmail.com" });
                _people.Add(new personn() { name = "jiju", age = 49, Aadhaar = "AA958684", email = "jiju@gmail.com" });
            }
            return _people;
        }

        public static personn Search(string pAadhaar)
        {
            return getpeople().Where(p => p.Aadhaar == pAadhaar).FirstOrDefault();
            
        }

        internal static void createnew(personn p)
        {
            getpeople();
            _people.Add(p);
        }

        internal  static List<personn> Searchinage(int startAge, int endAge)
        {
            var range1 = getpeople().Where(p => p.age >= startAge && p.age <= endAge).ToList();
            return range1;
        }
    }
}
