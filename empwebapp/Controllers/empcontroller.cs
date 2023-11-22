using empwebapp.Models;
using Microsoft.AspNetCore.Mvc;
using emplib;

namespace empwebapp.Controllers
{
    public class empcontroller : Controller
    {
        
        [HttpGet("/getemplist")]
        public IActionResult getemplist()
        {
            var emps = empoperations.getemplist();
            //display view
            return View("getemplist", emps);
        }
        [HttpGet("/search/{eAadhaar}")]
        public IActionResult getempdetails(String sAadhaar)
        {
            var found = empoperations.search(sAadhaar);
            return View("search", found);
        }
        [HttpGet("/create")]
        public IActionResult create()
        {
            return View("create", new empp());

        }
        [HttpPost("/create")]
        public IActionResult create([FromForm] empp e)
        {
            empoperations.createnew(e);

            return View("peoplelist", empoperations.getemplist());

        }
        [HttpGet("/edit/{eAadhaar}")]
        public IActionResult edit(string eAadhaar)
        {
            var found = empoperations.search(eAadhaar);
            return View("edit", found);
        }
        [HttpPost("/edit")]
        public IActionResult edit(string pAadhaar, [FromForm] empp e)
        {
            var found = empoperations.search(pAadhaar);
            found.ename = e.ename;
            found.eemail = e.eemail;
            found.esalary = e.esalary;
            return View("peoplelist", empoperations.getemplist());
        }
       
            [HttpGet("/getallemp")]
            public IActionResult getallemp()
            {
            var emps = emplib.employee.Get();
                //display view
            return View("getallemp", emps);
            }
        
    }

}


