using RepositoryPattern.Core.Models;
using RepositoryPattern.Infrastructure.Interfaces;

namespace RepositoryPattern.Infrastructure.Repositories
{
	public class AuthorRepository : IAuthorRepository
	{
		private readonly ApplicationDbContext _context;

		public AuthorRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public Author GetById(int id)
		{
			return _context.Authors.Find(id);
		}
	}
}
