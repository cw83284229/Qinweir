using Qinweir.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qinweir.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class QinweirPageModel : AbpPageModel
    {
        protected QinweirPageModel()
        {
            LocalizationResourceType = typeof(QinweirResource);
        }
    }
}