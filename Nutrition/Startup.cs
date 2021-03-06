﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Nutrition.Startup))]

namespace Nutrition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
