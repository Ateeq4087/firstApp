using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using firstapi1.models;
using static firstapi1.models.personapi;

namespace firstapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private Iapilogger _logger;
        public PersonController(Iapilogger logger) 
        {
            _logger = logger;

        }
        [HttpGet("/api/people")]
        public IActionResult getpeople()
        {
            _logger.log("getpeople() api call successful..!");
            return Ok(personnoperations.getpeople());
        }
        [HttpPost("/api/people")]
        public IActionResult Createperson([FromBody]personn p)
        {
            personnoperations.createnew(p);
            _logger.log("getpeople() api call successful..!");
            return Created($"Created person with Aadhaar {p.Aadhaar} Successfully", p);

        }
        [HttpPut("/api/update/{pAadhaar}")]
        public IActionResult updateperson([FromRoute]string pAadhaar, [FromBody] personn updatedperson)
        {
            try
            {
                personnoperations.update(pAadhaar, updatedperson);
                _logger.log("getpeople() api call successful..!");
                return Ok("update suucessfull");
            }
            catch (Exception ex)
            {
                _logger.log(ex.Message);                return NotFound(ex.Message);
            }
                      

        }
        [HttpDelete("/api/delete")]
        public IActionResult deleteperson([FromQuery]string pAadhaar)
        {
            try
            {
                personnoperations.delete(pAadhaar);
                _logger.log("getpeople() api call successful..!");
                return Ok("Delete Successfull");
            }
            catch (Exception ex)
            {
                _logger.log(ex.Message);
                return NotFound(ex.Message);
            }
            
        }
    }
}

