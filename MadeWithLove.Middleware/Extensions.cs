namespace MadeWithLove.Middleware
{
    using Owin;

    public static class Extensions
    {
        public static void MakeWithLove(this IAppBuilder app, string customIngredient = null)
        {
            app.Use<MadeWithLoveMiddleware>(customIngredient);
        }
    }
}
