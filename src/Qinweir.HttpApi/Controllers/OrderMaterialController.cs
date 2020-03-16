using Microsoft.AspNetCore.Mvc;
using Qinweir.Application.Contracts;
using Qinweir.Models.Test;
using Qinweir.OrderMaterial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Qinweir.Controllers
{
    [Route("api/OrderMaterial")]
    public class OrderMaterialController : QinweirController
    {
        public List<MaterialNameDTO> materialNames { get; set; }
        public UpdateCommonMaterialDTO updateCommonMaterialDTO { get; set; }
        private readonly IMaterialNameService _materialNameService;
        private readonly ICommonMaterialService _commonMaterialService;

        public OrderMaterialController(IMaterialNameService materialNameService, ICommonMaterialService commonMaterialService)
        {
            _materialNameService = materialNameService;
            _commonMaterialService = commonMaterialService;
        }

        [HttpGet]
        [Route("")]
        public async Task<UpdateCommonMaterialDTO> GetAsync()
        {
            PagedAndSortedResultRequestDto input = new PagedAndSortedResultRequestDto() { MaxResultCount = 200, SkipCount = 0, Sorting = "id" };

            var names=  _materialNameService.GetListAsync(input).Result.Items.ToList();

            List<UpdateBillMaterialsDTO> billlist = new List<UpdateBillMaterialsDTO>();

            UpdateCommonMaterialDTO updatecommonMaterialDTO = new UpdateCommonMaterialDTO();

            foreach (var item in names)
            {

                UpdateBillMaterialsDTO updateBillMaterialsDTO = new UpdateBillMaterialsDTO();
                updateBillMaterialsDTO.MaterialsType = item.MaterialsType;
                updateBillMaterialsDTO.MaterialsName = item.MaterialsName;
                updateBillMaterialsDTO.MateriralsPrice = item.UnitPrice;
                updateBillMaterialsDTO.units = item.units;
                billlist.Add(updateBillMaterialsDTO);
              
            }



            updatecommonMaterialDTO.BillMaterials = billlist;






            return updatecommonMaterialDTO;
        }


        [HttpPost]
        public async Task<CommonMaterialDTO> PostAsync(UpdateCommonMaterialDTO updateCommonMaterialDTO)
        {




           var data= await _commonMaterialService.CreateAsync(updateCommonMaterialDTO);



            return data;
        
        
        
        }
    }
}
