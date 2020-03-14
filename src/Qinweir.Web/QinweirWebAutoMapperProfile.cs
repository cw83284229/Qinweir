using AutoMapper;
using Qinweir.Application.Contracts;

namespace Qinweir.Web
{
    public class QinweirWebAutoMapperProfile : Profile
    {
        public QinweirWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.

            CreateMap<MaterialNameDTO, UpdateMaterialNameDTO>();
        }
    }
}
