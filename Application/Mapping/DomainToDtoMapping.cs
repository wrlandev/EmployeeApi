using AutoMapper;
using EmployeeApi.Domain.DTOs;
using EmployeeApi.Domain.Models;

namespace EmployeeApi.Application.Mapping
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping()
        {
            CreateMap<EmployeeModel, EmployeeDto>();
        }
    }
}
