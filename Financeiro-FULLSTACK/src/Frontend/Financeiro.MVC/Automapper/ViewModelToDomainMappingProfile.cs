using AutoMapper;
using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Entities.Systems.Transactions;
using Backend.Financeiro.Domain.Entities.Systems.Users;
using Financeiro.MVC.ViewModels;

namespace Financeiro.MVC.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<FinanceSystemViewModel, FinanceSystem>();
            CreateMap<FinanceSystemUserViewModel, FinanceSystemUser>();
            CreateMap<TransactionViewModel, Transaction>();
        }
    }
}
