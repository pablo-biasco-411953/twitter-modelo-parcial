using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwitterCloneApi.Services.Interface;

namespace TwitterCloneApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsControllers : ControllerBase
    {
        private ITweetServices _tweetservice;
        public TweetsControllers(ITweetServices tweetServices)
        {
            _tweetservice = tweetServices;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll(string pais)
        {
            try
            {
                var listTweets = _tweetservice.GetAll(pais);
                return Ok(await listTweets);
            }
            catch (Exception e )
            {
                return BadRequest(e);
            }
        }
    }
}
