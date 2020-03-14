using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Qinweir.Application.Contracts;
using Qinweir.OrderMaterial;

namespace Qinweir.Web.Pages.MaterialName
{
    public class EditModel : QinweirPageModel
    {
        //public void OnGet()
        //{

        //}

        [HiddenInput]
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }


        [BindProperty]
        public UpdateMaterialNameDTO materialName { get; set; }

        private readonly IMaterialNameService _materialNameService;

        public EditModel (IMaterialNameService materialNameService)
        {
            _materialNameService = materialNameService;
        }


        public async Task OnGetAsync()
        {
            var materialNameDTO = await _materialNameService.GetAsync(Id);
            materialName = ObjectMapper.Map<MaterialNameDTO, UpdateMaterialNameDTO>(materialNameDTO);

        }


        public async Task<IActionResult> OnPostAsync()
        {
            var data = await _materialNameService.UpdateAsync(Id, materialName);

            return NoContent();
        }







    }
}