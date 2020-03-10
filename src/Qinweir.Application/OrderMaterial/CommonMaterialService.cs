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
  public class CommonMaterialService:

       CrudAppService< //Defines CRUD methods
           CommonMaterial,
           CommonMaterialDTO, //Used to show books
           int, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
         UpdateCommonMaterialDTO, //Used to create a new book
         UpdateCommonMaterialDTO>,ICommonMaterialService //Used to update a

    {
        public CommonMaterialService(IRepository<CommonMaterial, int> repository)
            : base(repository)

        { }
    }
}
