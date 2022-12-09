using GraphiQl;

namespace Caesars_Pokemon_TBuilder
{
    public class Startup
    {
        public const string GraphQlPath = "/graphql";
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            // ...
            app.UseGraphiQl(GraphQlPath);
        }
    }
}
