namespace MadeWithLove.WebApi
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public class MadeWithLoveHandler : DelegatingHandler
    {
        private readonly MadeWithLoveOptions options;

        public MadeWithLoveHandler(MadeWithLoveOptions options = null)
        {
            this.options = options ?? new MadeWithLoveOptions();
        }

        public MadeWithLoveHandler(HttpMessageHandler handler, MadeWithLoveOptions options = null)
            : base(handler)
        {
            this.options = options ?? new MadeWithLoveOptions();
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var responseMessage = await base.SendAsync(request, cancellationToken);

            if (responseMessage != null)
                responseMessage.Headers.Add("x-made-with", options.Ingredient);

            return responseMessage;
        }
    }
}
