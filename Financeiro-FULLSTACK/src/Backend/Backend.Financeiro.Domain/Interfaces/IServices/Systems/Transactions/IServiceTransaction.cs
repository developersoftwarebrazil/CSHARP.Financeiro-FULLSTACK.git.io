﻿using Backend.Financeiro.Domain.Entities.Systems.Transactions;

namespace Backend.Financeiro.Domain.Interfaces.IServices.Systems.Transactions
{
    public interface IServiceTransaction
    {
        Task AddTransaction(Transaction transaction);
        Task UpdateTransaction(Transaction transaction);
        Task<object> GraphicLoad(string userEmail);
    }
}
