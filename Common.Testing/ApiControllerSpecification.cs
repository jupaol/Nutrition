using System;
using System.Web.Http;
using Ploeh.AutoFixture.Kernel;

namespace Nutrition.Common.Testing
{
    internal class ApiControllerSpecification : IRequestSpecification
    {
        public bool IsSatisfiedBy(object request)
        {
            var requestType = request as Type;

            return requestType != null && typeof (ApiController).IsAssignableFrom(requestType);
        }
    }
}
