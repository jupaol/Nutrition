using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Kernel;

namespace Nutrition.Common.Testing
{
    public class ApiControllerCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(
                new FilteringSpecimenBuilder(
                    new Postprocessor(
                        new MethodInvoker(
                            new ModestConstructorQuery()),
                        new ApiControllerFiller()),
                    new ApiControllerSpecification()));
        }
    }
}
