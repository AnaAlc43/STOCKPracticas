﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.COMMON.Entities;

namespace Stock.COMMON.Interfaces.Repositories
{
    public interface IProviderRepositories : IUnitOfWork
    {
        Task Create(Provider provider);
        Task Update(Provider provider);
        Task Delete(Provider provider);
        Task<Provider> GetAllProvider(int provider);        
    }
}