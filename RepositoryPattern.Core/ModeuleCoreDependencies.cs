using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace RepositoryPattern.Core
{
	public static class ModeuleCoreDependencies
	{
		public static void AddCoreDependencies(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly()); // current assembly.
		}
	}
}
