using AutoMapper;
using SGearzAPI.API.DTO;
using SGearzAPI.API.Model;

namespace SGearzAPI.API.Helper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Customer, CustomerForDetailDTO>();
            CreateMap<Customer, CustomerForListDTO>();
            CreateMap<CustAddress, CustAddressDTO>();
        }
    }
}