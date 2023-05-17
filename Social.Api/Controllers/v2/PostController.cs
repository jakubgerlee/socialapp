using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Social.Api.Models;

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
	
	[HttpPost]
	[Route("/Person")]
	public IActionResult AddPerson([FromBody] Person person)
	{
		return Ok(person);
	}
}
