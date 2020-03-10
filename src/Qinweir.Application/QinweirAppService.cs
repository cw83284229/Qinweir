using System;
using System.Collections.Generic;
using System.Text;
using Qinweir.Localization;
using Volo.Abp.Application.Services;

namespace Qinweir
{
    /* Inherit your application services from this class.
     */
    public abstract class QinweirAppService : ApplicationService
    {
        protected QinweirAppService()
        {
            LocalizationResource = typeof(QinweirResource);
        }
    }
}
