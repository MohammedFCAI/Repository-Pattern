namespace RepositoryPattern.Infrastructure.Interfaces
{
	public interface IUnitOfWork
	{
		IAuthorRepository AuthorRepository { get; }
		IBookRepository BookRepository { get; }
	}
}
