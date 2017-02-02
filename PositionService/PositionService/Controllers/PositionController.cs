namespace PositionService.Controllers
{
    using System.Web.Http;
    public class PositionController : ApiController
    {
        [Route("api/positions")]
        [HttpGet]
        public IHttpActionResult GetPositions()
        {
            return Ok();
        }

    }
}
