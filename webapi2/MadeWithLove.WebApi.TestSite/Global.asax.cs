namespace MadeWithLove.WebApi.TestSite
{
    using System;
    using System.Web.Http;

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configuration.MessageHandlers.Add(new MadeWithLoveHandler());
            GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
            GlobalConfiguration.Configuration.EnsureInitialized();
        }
    }
}