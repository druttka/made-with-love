# Made With Love

This middleware will ensure that all of your response include the `x-made-with` header set to `<3`.

### Why?

Because all the designers are putting it in their footers.

> Made with <3

Those of us working on the HTTP APIs that power the web have been left with no way to make sure everyone knows that **we care too**.

### Owin Middleware Usage

    app.MakeWithLove();

To set a custom ingredient instead of the default "<3", just pass in `MadeWithLoveOptions`

    app.MakeWithLove(new MadeWithLoveOptions { Ingredient = "love" });

### Web API 2 Usage

    config.MessageHandlers.Add(new MadeWithLoveHandler());

To set a custom ingredient instead of the default "<3", just pass in `MadeWithLoveOptions`

    config.MessageHandlers.Add(new MadeWithLoveOptions { Ingredient = "love" });

### Coming soon

- Express middleware
- Rack middleware
- ?!
