using RepositoryPattern.Infrastructure.Interfaces;

namespace RepositoryPattern.Infrastructure.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		public IAuthorRepository AuthorRepository { get; }
		public IBookRepository BookRepository { get; }

		public UnitOfWork(IAuthorRepository authorRepository, IBookRepository bookRepository)
		{
			AuthorRepository = authorRepository;
			BookRepository = bookRepository;
		}
	}
}
