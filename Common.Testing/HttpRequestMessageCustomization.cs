﻿using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using Ploeh.AutoFixture;

namespace Nutrition.Common.Testing
{
    internal class HttpRequestMessageCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customize<HttpRequestMessage>(c => c
                .Without(x => x.Content)
                .Do(x => x.Properties[HttpPropertyKeys.HttpConfigurationKey] =
                    new HttpConfiguration()));
        }
    }
}
