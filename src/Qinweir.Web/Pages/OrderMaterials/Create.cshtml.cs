using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Qinweir.Application.Contracts;
using Qinweir.OrderMaterial;
using Volo.Abp.Application.Dtos;

namespace Qinweir.Web.Pages.OrderMaterials
{
    public class CreateModel : QinweirPageModel
    {
        //public void OnGet()
        //{

        //}

        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }


        [BindProperty]
        public  List<MaterialNameDTO> materialNames { get; set; }
        public UpdateCommonMaterialDTO updateCommonMaterialDTO { get; set; }
        private readonly IMaterialNameService _materialNameService;
        private readonly  ICommonMaterialService _commonMaterialService;

        public CreateModel(IMaterialNameService materialNameService, ICommonMaterialService commonMaterialService)
        {
            _materialNameService = materialNameService;
            _commonMaterialService = commonMaterialService;
        }

        public async Task OnGetAsync()
        {
            var materialNameDTO = await _materialNameService.GetAsync(2);


            PagedAndSortedResultRequestDto input = new PagedAndSortedResultRequestDto() { MaxResultCount=200 ,SkipCount=0,Sorting="id" };



            var data = await _materialNameService.GetListAsync(input);
               materialNames = data.Items.ToList();
            //  materialName = materialNameDTO;

        }

        public async Task<IActionResult> OnPostAsync()
        {
           

            var data = await _commonMaterialService.CreateAsync(updateCommonMaterialDTO);

            return NoContent();
        }





    }
}