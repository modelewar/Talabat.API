﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Repository.Data;
using Talabate.Core.Entites;
using Talabate.Core.Repositories;

namespace Talabat.Repository
{
    public class GenericRepository<T> : IGenaricRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _dbContext;

        public GenericRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            if (typeof(T)==typeof(Product))
                return (IEnumerable<T>)await _dbContext.Products.Include(p => p.ProductBrand).Include(p => p.ProductType).ToListAsync();

            else
                return await _dbContext.Set<T>().ToListAsync();
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
