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
  public  class MaterialNameService:
        CrudAppService< //Defines CRUD methods
           MaterialName,
           MaterialNameDTO, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
           UpdateMaterialNameDTO, //Used to create a new book
           UpdateMaterialNameDTO>,IMaterialNameService//Used to update a

    {

        public MaterialNameService(IRepository<MaterialName, int> repository)
            : base(repository)

        { 
        
        
        
        
        }





    }
}
