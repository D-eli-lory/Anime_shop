using Animeshop.Domain.Response;
using Animeshop.Domain.Entity;
using Animeshop.Service.Interfaces;
using Animeshop.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animeshop.DAL.Interfaces;

namespace Animeshop.Service.Realiz
{
    public class AProductsService : IAProductsService
    {
        private readonly IAProductsRepository _aProductsRepository;

        public AProductsService(IAProductsRepository aProductsRepository)
        {

            _aProductsRepository = aProductsRepository;
        }
       
        public async Task<IBaseResponse<IEnumerable<AProducts>>> GetAProducts()
        {
            var baseResponse = new BaseResponse<IEnumerable<AProducts>>();
            try
            {
                var aproducts = await _aProductsRepository.Select();
                if (aproducts.Count == 0)
                {
                    baseResponse.Description = "Найдено 0 элементов";
                    baseResponse.StatusCode = StatusCode.OK;
                    return baseResponse;
                }

                baseResponse.Data = aproducts;
                baseResponse.StatusCode = StatusCode.OK;

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<AProducts>>()
                {
                    Description = $"[GetAProducts]: {ex.Message}"
                };
            }
        }

        Task<IBaseResponse<IEnumerable<AProducts>>> IAProductsService.GetAProducts()
        {
            throw new NotImplementedException();
        }
    }
}
