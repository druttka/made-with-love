namespace MadeWithLove.Middleware
{
    using Microsoft.Owin;
    using System.Threading.Tasks;

    public class MadeWithLoveMiddleware : OwinMiddleware
    {
        private readonly string customIngredient;

        public MadeWithLoveMiddleware(OwinMiddleware next, string customIngredient = null)
            : base(next)
        {
            this.customIngredient = customIngredient;
        }

        public override async Task Invoke(IOwinContext context)
        {
            context.Response.Headers.Set("x-made-with", customIngredient ?? "<3");
            await Next.Invoke(context);
        }
    }
}
