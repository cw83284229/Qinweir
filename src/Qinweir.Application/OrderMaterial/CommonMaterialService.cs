using Qinweir.Application.Contracts;
using Qinweir.OrderMaterials;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Qinweir.OrderMaterial
{
  public class CommonMaterialService:

       CrudAppService< //Defines CRUD methods
           CommonMaterial,
           CommonMaterialDTO, //Used to show books
           int, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
         UpdateCommonMaterialDTO, //Used to create a new book
         UpdateCommonMaterialDTO>,ICommonMaterialService //Used to update a

    {


        IRepository<CommonMaterial> _repository;
        IRepository<BillMaterials> _billMaterials;
        public CommonMaterialService(IRepository<CommonMaterial, int> repository, IRepository<BillMaterials> billMaterials)
            : base(repository)

        {

            _repository = repository;
            _billMaterials = billMaterials;
        
        
        }
        public override Task<CommonMaterialDTO> CreateAsync(UpdateCommonMaterialDTO input)
        {
           // ObjectMapper.Map<CommonMaterialDTO, CommonMaterial>(input);

          // var data= _repository.InsertAsync();
         var data= base.CreateAsync(input);

           

            return data;
        }


        public override async Task<CommonMaterialDTO> GetAsync(int id)
        {



         var data=  await _repository.GetListAsync();
        

         var list=   ObjectMapper.Map<List<CommonMaterial>,List<CommonMaterialDTO>>(data).FirstOrDefault();
            var BIL = _billMaterials.Where(u => u.CommonMaterialId == list.Id).ToList();
            var billdata = ObjectMapper.Map<List<BillMaterials>, List<BillMaterialsDTO>>(BIL);
            list.BillMaterials = billdata;
            return list;
        }

        public override async Task<PagedResultDto<CommonMaterialDTO>> GetListAsync(PagedAndSortedResultRequestDto input)
        {

            var data = await _repository.GetListAsync();

            foreach (var item in data)
            {

               item.BillMaterials= _billMaterials.Where(u => u.CommonMaterialId == item.Id).ToList();
            }


            var list = ObjectMapper.Map<List<CommonMaterial>, List<CommonMaterialDTO>>(data);

           
            
            
            return   new PagedResultDto<CommonMaterialDTO> { Items=list,TotalCount=list.Count} ;
        }


        public async Task<PagedResultDto<OrderMaterialDTO>> GetOrderListAsync(PagedAndSortedResultRequestDto input, string orderTime, string orderShop)

        {

            var data = from a in _repository
                       join b in _billMaterials on a.Id equals b.CommonMaterialId
                       select new OrderMaterialDTO
                       {
                           Id=b.Id,
                           OrderStore = a.OrderStore,
                           OrderTime = a.OrderTime,
                           MaterialsType = b.MaterialsType,
                           MaterialsName = b.MaterialsName,
                           units = b.units,
                           MateriralsPrice = b.MateriralsPrice,
                           MateriralsCount = b.MateriralsCount,
                           Remark = b.Remark
                       };

            if (!string.IsNullOrEmpty(orderTime))
            {
                data = data.Where(u => u.OrderTime == orderTime);
            }
            if (!string.IsNullOrEmpty(orderShop))
            {
                data = data.Where(u => u.OrderStore == orderShop);
            }

            data = data.OrderBy(d => d.Id).PageBy(input.SkipCount, input.MaxResultCount);

            return new PagedResultDto<OrderMaterialDTO> { TotalCount = data.ToList().Count, Items = data.ToList() };

        }

    }
}
