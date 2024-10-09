using Asp.Versioning;

namespace CWKSocail.Api.Controllers.V1
{
	[ApiVersion("1.0")]
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiController]
	public class PostController : Controller
	{


		[HttpGet]
		[Route("{id}")]
		public IActionResult GetById(int id)
		{
			 
			return Ok();
		}

	}
}
