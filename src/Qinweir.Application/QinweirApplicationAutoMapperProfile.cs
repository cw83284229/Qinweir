using AutoMapper;
using Qinweir.Application.Contracts;
using Qinweir.OrderMaterial;
using Qinweir.OrderMaterials;

namespace Qinweir
{
    public class QinweirApplicationAutoMapperProfile : Profile
    {
        public QinweirApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */


            CreateMap<CommonMaterial, CommonMaterialDTO>();
            CreateMap<UpdateCommonMaterialDTO, CommonMaterial>();
            CreateMap<BillMaterials, BillMaterialsDTO>();
            CreateMap<UpdateBillMaterialsDTO, BillMaterials>();
            CreateMap<MaterialName, MaterialNameDTO>();
            CreateMap<UpdateMaterialNameDTO, MaterialName>();



        }
    }
}
