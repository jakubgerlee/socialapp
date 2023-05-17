using Social.Api.Filters;
using Social.Api.Options;

namespace Social.Api.Registers;

public class SwaggerRegister : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(opt =>
        {
            opt.SchemaFilter<XEnumNamesSchemaFilter>();
        });

        builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
    }
}
