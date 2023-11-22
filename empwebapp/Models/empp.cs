using System.ComponentModel.DataAnnotations;

namespace empwebapp.Models
{
    public class empp
    {
        [Required]
        public string eAadhaar { get; set; }
        [MaxLength(1000)]
        public string ename { get; set; }
        [Range(10, 110)]
        public int esalary { get; set; }
        [EmailAddress]
        public string eemail { get; set; }
    }
    public class empoperations
    {
        static List<empp> _empp = new List<empp>();
        public static List<empp> getemplist()
        {
            if (_empp.Count == 0)
            {

                _empp.Add(new empp() { ename = "ateeq1", esalary = 22000, eAadhaar = "AA12345", eemail = "ateeq1@gmail.com" });
                _empp.Add(new empp() { ename = "kanishq", esalary = 21000, eAadhaar = "AA34342", eemail = "kanishq@gmail.com" });
                _empp.Add(new empp() { ename = "ismail", esalary = 49000, eAadhaar = "AA958684", eemail = "ismail@gmail.com" });
                _empp.Add(new empp() { ename = "shivam", esalary = 56000, eAadhaar = "AA876542", eemail = "shivam@gmail.com" });
            }
            return _empp;
        }
        public static empp search(string sAadhaar)
        {
            return getemplist().Where(e => e.eAadhaar == sAadhaar).FirstOrDefault();

        }
        internal static void createnew(empp e)
        {
            getemplist();
            _empp.Add(e);
        }

        
    }
}
