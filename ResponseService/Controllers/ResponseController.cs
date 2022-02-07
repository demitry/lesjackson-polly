using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    //api/Response
    [Route("api/[Controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        //GET /api/response/100
        [Route("{id:int}")]
        [HttpGet]
        public ActionResult GetAResponse(int id)
        {
            return Ok();
        }
    }
}