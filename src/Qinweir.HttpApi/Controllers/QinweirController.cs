using Qinweir.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qinweir.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class QinweirController : AbpController
    {
        protected QinweirController()
        {
            LocalizationResource = typeof(QinweirResource);
        }
    }
}