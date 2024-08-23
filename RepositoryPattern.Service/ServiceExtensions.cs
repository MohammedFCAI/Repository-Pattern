using Microsoft.Extensions.DependencyInjection;
using RepositoryPattern.Service.Implementations;
using RepositoryPattern.Service.Interfaces;

namespace RepositoryPattern.Service
{
	public static class ServiceExtensions
	{
		public static void AddServiceExtensions(this IServiceCollection services)
		{
			services.AddTransient<IBookService, BookService>();
			services.AddTransient<IAuthorService, AuthorSerivce>();
		}
	}
}
