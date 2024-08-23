using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Service.Interfaces;

namespace RepositoryPattern.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorController : ControllerBase
	{
		private readonly IAuthorService _authorService;

		public AuthorController(IAuthorService authorService)
		{
			_authorService = authorService;
		}



		[HttpGet("id")]
		public IActionResult GetById(int id)
		{
			var author = _authorService.GetById(id);
			if (author == null)
			{
				return NotFound("Id not found..!");
			}
			return Ok(author);
		}
	}
}
