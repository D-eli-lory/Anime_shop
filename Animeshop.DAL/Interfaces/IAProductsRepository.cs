using Animeshop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animeshop.DAL.Interfaces
{
    public interface IAProductsRepository : IBaseRepository<AProducts>
    {
        Task<AProducts> GetByName(string name);

    }
}
