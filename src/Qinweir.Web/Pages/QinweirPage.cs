using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Qinweir.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qinweir.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Qinweir.Web.Pages.QinweirPage
     */
    public abstract class QinweirPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<QinweirResource> L { get; set; }
    }
}
