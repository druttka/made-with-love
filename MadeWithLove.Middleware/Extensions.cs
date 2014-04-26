namespace MadeWithLove.Middleware
{
    using Owin;

    public static class Extensions
    {
        public static void MakeWithLove(this IAppBuilder app, string customIngredient)
        {
            app.Use<MadeWithLoveMiddleware>(customIngredient);
        }
    }
}
