using Microsoft.Extensions.DependencyInjection;
using RepositoryPattern.Infrastructure.Interfaces;
using RepositoryPattern.Infrastructure.Repositories;

namespace RepositoryPattern.Infrastructure
{
	public static class RepositoryExtensions
	{
		public static void AddRepositoryExtensions(this IServiceCollection services)
		{
			services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddTransient<IUnitOfWork, UnitOfWork>();
			services.AddTransient<IAuthorRepository, AuthorRepository>();
			services.AddTransient<IBookRepository, BookRepository>();
		}
	}
}
