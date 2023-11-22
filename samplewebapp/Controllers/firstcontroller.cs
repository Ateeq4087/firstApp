using Microsoft.AspNetCore.Mvc;
using samplewebapp.Models;

namespace samplewebapp.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet("/greet")]
        public IActionResult greet()
        {
            return Ok("Hello, I'm a web function result");
        }

        [HttpGet("/simplegreet/{pname}")]
        public string simplegreet(string pname)
        {
            return $" Welcome to MVC,{pname}";
        }
        [HttpGet("/getnames")]
        public List<string> getnames()
        { 
            var names = new List<string>() {"ateeq","ateeq1","ateeq2"};
            return names;
        }
        [HttpGet("/Add/{pname}/{pmarks}/{ispassed}")]
        public string adddate(string pname,int pmarks,bool ispassed)
        {
            return $"{pname} secure {pmarks} in examination out of 100 and status is {ispassed}";
        }
        [HttpGet("/main")]
        public IActionResult getndexpage()
        {

            ViewBag.ReturnValue = "\n\tData passed from controller to view";
            return View("mainpage");
        }
        
       
        /*[HttpGet("/people/of/age/{startAge}/{endAge}")]
        public IActionResult GetPeopleWithinAge(int startAge, int endAge)
        {
            var range1 = personnoperations.Searchinage(startAge, endAge);
            return View("GetPeopleWithinAge", range1);

        }*/


    }
}
