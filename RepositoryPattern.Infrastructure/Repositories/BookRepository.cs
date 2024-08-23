using RepositoryPattern.Core.Models;
using RepositoryPattern.Infrastructure.Interfaces;

namespace RepositoryPattern.Infrastructure.Repositories
{
	public class BookRepository : IBookRepository
	{
		private readonly ApplicationDbContext _context;

		public BookRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public Book GetById(int id)
		{
			return _context.Books.Find(id);
		}
	}
}
