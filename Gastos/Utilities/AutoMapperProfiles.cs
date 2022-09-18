using AutoMapper;
using Gastos.Entities;

namespace Gastos.Utilities
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            // Users
            CreateMap<DTOs.Users.GetByIdDTO, User>();
            CreateMap<DTOs.Users.InsertDTO, User>();

            // Accounts
            CreateMap<DTOs.Accounts.InsertDTO, Account>();
        }
    }
}
