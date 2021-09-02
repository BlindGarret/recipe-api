using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RecipeBook.Api.Controllers
{
    /// <inheritdoc />
    [Route("api/ping")]
    [ApiController]
    public class PingController : ControllerBase
    {
        /// <summary>
        /// Simple ping call for testing connectivity
        /// </summary>
        [HttpGet]
        public ActionResult Ping()
        {
            return Ok();
        }

        /// <summary>
        /// Simple Auth ping call for testing connectivity
        /// </summary>
        [Authorize]
        [HttpGet("authPing")]
        public ActionResult PingAuth()
        {
            return Ok();
        }
    }
}
