using System;
using System.Net.Http;
using System.Web.Http;
using Ploeh.AutoFixture.Kernel;

namespace Nutrition.Common.Testing
{
    internal class ApiControllerFiller : ISpecimenCommand
    {
        public void Execute(object specimen, ISpecimenContext context)
        {
            if (specimen == null)
                throw new ArgumentNullException("specimen");
            if (context == null)
                throw new ArgumentNullException("context");

            var target = specimen as ApiController;
            if (target == null)
                throw new ArgumentException(
                    "The specimen must be an instance of ApiController.",
                    "specimen");

            target.Request =
                (HttpRequestMessage)context.Resolve(
                    typeof(HttpRequestMessage));
        }
    }
}
