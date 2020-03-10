using Qinweir.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Qinweir
{
  public  interface ICommonMaterialService:
         ICrudAppService< //Defines CRUD methods
            CommonMaterialDTO, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
          UpdateCommonMaterialDTO, //Used to create a new book
          UpdateCommonMaterialDTO> //Used to update a






    {
    }
}
