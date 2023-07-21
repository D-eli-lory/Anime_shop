using Animeshop.DAL.Interfaces;
using Animeshop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Animeshop.DAL.Repositories
{
    public class AProductsRepository : IAProductsRepository
    {
        private readonly ApplicationDbContext _db;

        public AProductsRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> Create(AProducts entity)
        {
            await _db.AProducts.AddAsync(entity);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<AProducts> Get(int id)
        {
            return await _db.AProducts.FirstOrDefaultAsync(x => x.id == id);
        }
        public async Task<List<AProducts>> Select()
        {
            return await _db.AProducts.ToListAsync();

        }

        public async Task<bool> Delete(AProducts entity)
        {
            _db.AProducts.Remove(entity);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<AProducts> Update(AProducts entity)
        {
            _db.AProducts.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<AProducts> GetByName(string name)
        {
            return await _db.AProducts.FirstOrDefaultAsync(x => x.ProductName == name);
        }

    }
}
