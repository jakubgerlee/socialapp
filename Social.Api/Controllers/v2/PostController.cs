using Microsoft.AspNetCore.Mvc;

namespace Social.Api.Controllers.v2;

[ApiVersion("2.0")]
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
