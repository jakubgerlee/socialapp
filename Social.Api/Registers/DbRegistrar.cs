using Microsoft.EntityFrameworkCore;
using Social.Dal;

namespace Social.Api.Registers;

public class DbRegistrar : IWebApplicationBuilderRegistrar
{
    public void RegisterServices(WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("Default");

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }
}