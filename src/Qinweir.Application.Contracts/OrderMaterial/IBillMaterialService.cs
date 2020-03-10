using Qinweir.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Qinweir.OrderMaterial
{
  public   interface IBillMaterialService:

         ICrudAppService< //Defines CRUD methods
            BillMaterialsDTO, //Used to show books
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
            UpdateBillMaterialsDTO, //Used to create a new book
            UpdateBillMaterialsDTO> //Used to update a



    {
    }
}
