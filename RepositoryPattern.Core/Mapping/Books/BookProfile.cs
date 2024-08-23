using AutoMapper;
using RepositoryPattern.Core.Books.Response;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Core.Mapping.Books
{
	public partial class BookProfile : Profile
	{
		public BookProfile()
		{
			GetBookByIdMapping();
		}

		private void GetBookByIdMapping()
		{
			CreateMap<Book, GetBookByIdResponse>()
				.ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
				.ReverseMap();
		}
	}
}
