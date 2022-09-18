using AutoMapper;
using Gastos.DTOs.Accounts;
using Gastos.DTOs.Users;
using Gastos.Entities;

namespace Gastos.Utilities
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            // Users
            CreateMap<GetByIdDTO, User>();

            // Accounts
            CreateMap<InsertDTO, Account>();
        }
    }
}
