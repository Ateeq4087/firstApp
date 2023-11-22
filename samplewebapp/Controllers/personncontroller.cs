using Microsoft.AspNetCore.Mvc;
using samplewebapp.Models;

namespace samplewebapp.Controllers
{
    public class personncontroller : Controller
    {
        [HttpGet("/peoplelist")]
        public IActionResult getpeople()
        {
            var people = personnoperations.getpeople();
            //display view
            return View("peoplelist",people);
        }
        [HttpGet("/Search/{pAadhaar}")]
        public IActionResult getpersonndetails(String pAadhaar)
        {
            var found = personnoperations.Search(pAadhaar);
            return View("Search", found);
        }
        [HttpGet("/age/{startAge}/{endAge}")]
        public IActionResult GetPeopleWithinAge(int startAge, int endAge)
        {
            var range1 = personnoperations.Searchinage(startAge, endAge);
            return View("GetPeopleWithinAge", range1);

        }
        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View("create",new personn());

        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm]personn p)
        {
            personnoperations.createnew(p);

            return View("peoplelist",personnoperations.getpeople());

        }
        [HttpGet("/edit/{pAadhaar}")]
        public IActionResult edit(string pAadhaar)
        {
            var found = personnoperations.Search(pAadhaar);
            return View("edit", found);
        }
        [HttpPost("/edit")]
        public IActionResult edit(string pAadhaar, [FromForm]personn p)
        {
            var found = personnoperations.Search(pAadhaar);
            found.name = p.name;
            found.email = p.email;
            found.age = p.age;
            return View("peoplelist", personnoperations.getpeople());
        }

    }
}
