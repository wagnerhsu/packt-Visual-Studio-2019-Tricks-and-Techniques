// <auto-generated> - Template:AutoMapperProfile, Version:2.0, Id:a72dc8d8-f6c5-422a-9554-93fa6dc17282
using AutoMapper;
using xDTO = CGHClientServer1.DTO.CSC;
using xENT = CGHClientServer1.DB.Entities;

namespace CGHClientServer1.Repository.Infrastructure
{
	public partial class CSCAutoMapperProfile : Profile
	{
		public CSCAutoMapperProfile()
		{
			InitializeProfile();
			InitializePartial();
		}

		partial void InitializePartial();

		private void InitializeProfile()
		{
			CreateMap<xDTO.City, xENT.City>()
				.ForMember(d => d.State, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.State, opt => opt.Ignore())
			.ReverseMap();

			CreateMap<xDTO.Country, xENT.Country>()
				.ForMember(d => d.States, opt => opt.Ignore()) // Reverse nav
			.ReverseMap();

			CreateMap<xDTO.State, xENT.State>()
				.ForMember(d => d.Cities, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Country, opt => opt.Ignore()) // Reverse nav
				.ForMember(d => d.Country, opt => opt.Ignore())
			.ReverseMap();

		}
	}
}
