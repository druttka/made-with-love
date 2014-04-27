namespace MadeWithLove.Middleware
{
    using Owin;

    public static class Extensions
    {
        public static void MakeWithLove(this IAppBuilder app, MadeWithLoveOptions options = null)
        {
            app.Use<MadeWithLoveMiddleware>(options);
        }
    }
}
