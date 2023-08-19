﻿using Backend.Financeiro.Domain.Entities.Systems;
using Backend.Financeiro.Domain.Interfaces.IServices.Systems;
using Backend.Financeiro.Domain.Interfaces.Systems;

namespace Backend.Financeiro.Domain.Services.Systems
{
    public class ServiceFinanceSystem : IServiceFinanceSystem
    {
        private readonly IFinanceSystem _financeSystem;
        public ServiceFinanceSystem(IFinanceSystem financeSystem)
        {
            _financeSystem = financeSystem;
        }
        public async Task AddFinanceSystem(FinanceSystem financeSystem)
        {
            var isValid = financeSystem.ValidatePropertyString(financeSystem.Name, "Name");
            if (isValid)
            {
                var date = DateTime.Now;

                financeSystem.MonthlyClosingDay = 1;
                financeSystem.Month = date.Month;
                financeSystem.Year = date.Year;
                financeSystem.MonthCopy = date.Month;
                financeSystem.YearCopy = date.Year;
                financeSystem.GenerateTransactionCopy = true;

                await _financeSystem.Add(financeSystem);
            }
        }

        public async Task UpdateFinanceSystem(FinanceSystem financeSystem)
        {
            var isValid = financeSystem.ValidatePropertyString(financeSystem.Name, "Name");
            if (isValid)
            {
                financeSystem.MonthlyClosingDay = 1;

                await _financeSystem.Update(financeSystem);
            }
        }
    }
}