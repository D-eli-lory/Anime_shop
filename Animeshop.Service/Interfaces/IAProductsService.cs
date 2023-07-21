using Animeshop.Domain.Response;
using Animeshop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Animeshop.Service.Interfaces
{
    public interface IAProductsService
    {
        Task<IBaseResponse<IEnumerable<AProducts>>> GetAProducts();

        //  Task<IBaseResponse<AProductsViewModel>> GetAProducts(int id);

        //   Task<IBaseResponse<AProductsViewModel>> CreateAProducts(AProductsViewModel AProductsViewModel);

        // Task<IBaseResponse<bool>> DeleteAProducts(int id);

        // Task<IBaseResponse<AProducts>> GetAProductsByName(string name);

        //Task<IBaseResponse<AProducts>> Edit(int id, AProductsViewModel model);
    }
}
