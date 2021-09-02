//-----------------------------------------------------------------------
// <copyright file="PingController.cs" company="Real Technology Solutions">
//     Author: blindgarret
//     Copyright (c) 2020 Real Technology Solutions. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RTS.Template.API.Controllers
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
