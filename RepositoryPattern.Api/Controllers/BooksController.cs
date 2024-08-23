using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Core.Books.Response;
using RepositoryPattern.Service.Interfaces;

namespace RepositoryPattern.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BooksController : ControllerBase
	{
		private readonly IBookService _bookservice;
		private readonly IMapper _mapper;

		public BooksController(IBookService bookservice, IMapper mapper)
		{
			_bookservice = bookservice;
			_mapper = mapper;
		}


		[HttpGet("id")]
		public IActionResult Get(int id)
		{
			var book = _bookservice.GetById(id);

			if (book is not null)
			{
				var bookMapping = _mapper.Map<GetBookByIdResponse>(book);
				return Ok(bookMapping);
			}

			return NotFound("Not found..!");
		}
	}
}
