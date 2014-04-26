using Microsoft.Owin;

[assembly: OwinStartup(typeof(MadeWithLove.TestSite.Startup))]

namespace MadeWithLove.TestSite
{
    using System;
    using System.Threading.Tasks;
    using MadeWithLove.Middleware;
    using Microsoft.Owin;
    using Owin;
    using System.Net;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MakeWithLove();
        }
    }
}
