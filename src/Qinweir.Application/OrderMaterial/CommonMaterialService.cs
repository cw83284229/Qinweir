using Qinweir.Application.Contracts;
using Qinweir.OrderMaterials;
using System;
using System.Collections.Generic;
using System.Linq;
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





    }
}
