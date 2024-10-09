using Asp.Versioning;

namespace CWKSocail.Api.Controllers.V2
{
	[ApiVersion("2.0")]
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiController]
	 
	public class PostController : Controller
{


	[HttpGet]
	[Route("{id}")]
	public IActionResult GetById(int id)
	{
 		return Ok( );
	}

}
}
