﻿using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Data.Common.Persistence.Repositories
{
    public class InfrastructureRepository : Repository<Infrastructure>, IInfrastructureRepository
    {
        public InfrastructureRepository(string root) : base(root)
        {
        }
        public string Root => _root;
    }
}