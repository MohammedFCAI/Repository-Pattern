namespace RepositoryPattern.Infrastructure.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		T GetById(int id);
	}
}
