using Microsoft.AspNetCore.Mvc;
using RequestService.Policies;

namespace RequestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RequestController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //GET api/request
        [HttpGet]
        public async Task<ActionResult> MakeRequest()
        {
            // Not recommended way to use HttpClient
            //var httpClient = new HttpClient();
            
            //Named client will have access to the Polly policy
            var httpClient = _httpClientFactory.CreateClient("Test");

            var response = await httpClient.GetAsync("http://localhost:5198/api/response/25");

            //var response = await _clientPolicy.ImmediateHttpRetry.ExecuteAsync(
            //    () =>  httpClient.GetAsync("http://localhost:5198/api/response/25"));

            // var response = await _clientPolicy.LinearHttpRetry.ExecuteAsync(
            //     () =>  httpClient.GetAsync("http://localhost:5198/api/response/25"));

            // var response = await _clientPolicy.ImmediateHttpRetry.ExecuteAsync(
            //     () =>  httpClient.GetAsync("http://localhost:5198/api/response/25"));

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