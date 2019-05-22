using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPattern.Controllers
{
    [Produces("application/json")]
    [Route("api/Base")]
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult BuildJsonResponse(int responseCode, object message, object data = null, object errors = null)
        {
            switch (responseCode)
            {
                case 400:
                    var response = new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    };
                    return BadRequest(response);
                case 409:
                    var resp = new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    };
                    return StatusCode(409, resp);
                case 404:
                    var resps = new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    };
                    return StatusCode(404, resps);
                case 200:
                    return Ok(new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    });
                case 500:
                    var KO = new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    };
                    return BadRequest(KO);
                case 402:

                    return StatusCode(402, new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    });
                default:
                    return StatusCode(500, new
                    {
                        Status = responseCode,
                        Message = message,
                        Errors = errors,
                        Data = data
                    });
            }
        }






    }
}