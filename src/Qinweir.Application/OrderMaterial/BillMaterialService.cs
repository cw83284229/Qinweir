using Qinweir.Application.Contracts;
using Qinweir.OrderMaterials;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Qinweir.OrderMaterial
{
  public  class BillMaterialService:
        CrudAppService< //Defines CRUD methods
            BillMaterials,
            BillMaterialsDTO, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            UpdateBillMaterialsDTO, //Used to create a new book
            UpdateBillMaterialsDTO> //Used to update a

    {

        public BillMaterialService(IRepository<BillMaterials, int> repository)
            : base(repository)

        { 
        
        
        
        
        }





    }
}
