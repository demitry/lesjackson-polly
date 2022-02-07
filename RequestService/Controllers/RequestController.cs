using Microsoft.AspNetCore.Mvc;

namespace RequestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        //GET api/request
        [HttpGet]
        public async Task<ActionResult> MakeRequest()
        {
            // Not recommended way to use HttpClient
            var httpClient = new HttpClient();

            //System.Net.Http.HttpRequestException: The SSL connection could not be established, see inner exception.
            //---> System.Security.Authentication.AuthenticationException: The remote certificate is invalid because of errors in the certificate chain: UntrustedRoot
            var response = await httpClient.GetAsync("http://localhost:5198/api/response/25");

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("ResponseSevice returned SUCCESS");
                return Ok();
            }
            else
            {
                Console.WriteLine("ResponseSevice returned FAILURE");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }
}