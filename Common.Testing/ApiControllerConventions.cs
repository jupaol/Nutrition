using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;

namespace Nutrition.Common.Testing
{
    public class ApiControllerConventions : CompositeCustomization
    {
        public ApiControllerConventions()
            : base(
                new HttpRequestMessageCustomization(),
                new ApiControllerCustomization(),
                new AutoNSubstituteCustomization()
                )
        {

        }
    }
}
