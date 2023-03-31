using Microsoft.AspNetCore.Mvc;
using Social.Domain.Models;

namespace Social.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : Controller
{
	[HttpGet]
	[Route("{id}")]
	public IActionResult GetById(int id)
	{
		var post = new Post { Id = id, Text = "Hello, world" };

		return Ok(post);
	}
}
