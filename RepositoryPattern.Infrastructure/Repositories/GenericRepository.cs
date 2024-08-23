using RepositoryPattern.Infrastructure.Interfaces;

namespace RepositoryPattern.Infrastructure.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private ApplicationDbContext _context;

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}
	}
}
