namespace MadeWithLove.Middleware
{
    using Microsoft.Owin;
    using System.Threading.Tasks;

    public class MadeWithLoveMiddleware : OwinMiddleware
    {
        public MadeWithLoveMiddleware(OwinMiddleware next)
            : base(next)
        {

        }

        public override async Task Invoke(IOwinContext context)
        {
            context.Response.Headers.Set("x-made-with", "<3");
            await Next.Invoke(context);
        }
    }
}
