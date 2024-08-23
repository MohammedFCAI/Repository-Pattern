using RepositoryPattern.Core.Models;
using RepositoryPattern.Infrastructure.Interfaces;
using RepositoryPattern.Service.Interfaces;

namespace RepositoryPattern.Service.Implementations
{
	public class BookService : IBookService
	{
		private readonly IUnitOfWork _unitOfWork;

		public BookService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}


		public Book GetById(int bookId)
		{
			var book = _unitOfWork.BookRepository.GetById(bookId);
			if (book is not null)
			{
				var author = _unitOfWork.AuthorRepository.GetById(bookId);
				book.Author = author;
			}

			return book;
		}
	}
}
