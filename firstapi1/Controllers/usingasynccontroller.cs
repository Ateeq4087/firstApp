using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace firstapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usingasynccontroller : ControllerBase
    {
        public usingasynccontroller()
        {
            System.IO.File.WriteAllText("somefile.txt", "checking again via firstapi");
        }
        [HttpGet("/async")]
        public async Task<string> Readfile()
        {
            using (StreamReader r = new StreamReader(@"somefile.txt"))
            {
                return await r.ReadToEndAsync();
            }
        }
    }
}
