using RepositoryPattern.Core.Models;
using RepositoryPattern.Infrastructure.Interfaces;
using RepositoryPattern.Service.Interfaces;

namespace RepositoryPattern.Service.Implementations
{
	public class AuthorSerivce : IAuthorService
	{
		private readonly IUnitOfWork _unitOfWork;

		public AuthorSerivce(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public Author GetById(int id)
		{
			var author = _unitOfWork.AuthorRepository.GetById(id);
			return author;
		}
	}
}
