using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CittaDashboard.Startup))]
[assembly: OwinStartup(typeof(CittaDashboard.Startup))]

namespace CittaDashboard
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
