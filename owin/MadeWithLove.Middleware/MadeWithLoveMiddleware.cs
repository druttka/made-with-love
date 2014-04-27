namespace MadeWithLove.Middleware
{
    using Microsoft.Owin;
    using System.Threading.Tasks;

    public class MadeWithLoveMiddleware : OwinMiddleware
    {
        private readonly MadeWithLoveOptions options;

        public MadeWithLoveMiddleware(OwinMiddleware next, MadeWithLoveOptions options = null)
            : base(next)
        {
            this.options = options ?? new MadeWithLoveOptions();
        }

        public override async Task Invoke(IOwinContext context)
        {
            context.Response.Headers.Set("x-made-with", options.Ingredient);
            await Next.Invoke(context);
        }
    }
}
