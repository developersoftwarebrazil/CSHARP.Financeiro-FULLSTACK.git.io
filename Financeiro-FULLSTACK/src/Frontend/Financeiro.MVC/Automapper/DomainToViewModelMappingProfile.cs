using AutoMapper;
using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Entities.Systems.Users;
using Financeiro.MVC.ViewModels;

namespace Financeiro.MVC.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<FinanceSystem, FinanceSystemViewModel>();
            CreateMap<FinanceSystemUser, FinanceSystemUserViewModel>();
            CreateMap<Transaction, TransactionViewModel>();
        }
    }
}
