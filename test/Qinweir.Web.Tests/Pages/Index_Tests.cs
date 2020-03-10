using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Qinweir.Pages
{
    public class Index_Tests : QinweirWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
