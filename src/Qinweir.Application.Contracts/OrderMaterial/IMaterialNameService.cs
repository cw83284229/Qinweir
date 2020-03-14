using Qinweir.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Qinweir.OrderMaterial
{
  public   interface IMaterialNameService :

         ICrudAppService< //Defines CRUD methods
           MaterialNameDTO, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            UpdateMaterialNameDTO, //Used to create a new book
            UpdateMaterialNameDTO> //Used to update a



    {
    }
}
