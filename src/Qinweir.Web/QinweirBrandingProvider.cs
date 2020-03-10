using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Qinweir.Web
{
    [Dependency(ReplaceServices = true)]
    public class QinweirBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qinweir";
    }
}
