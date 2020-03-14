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
    public class CreateModel : QinweirPageModel
    {
        public void OnGet()
        {

        }


        [BindProperty]
        public UpdateMaterialNameDTO materialNames { get; set; }

        private readonly IMaterialNameService _materialNameService;

        public CreateModel(IMaterialNameService materialNameService)
        {
            _materialNameService=materialNameService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
         var data=   await _materialNameService.CreateAsync(materialNames);
           
            return NoContent();
        }










    }
}