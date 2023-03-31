using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace Social.Api.Registers;

public class MvcRegister : IWebApplicationBuilderRegister
{
	public void RegisterServices(WebApplicationBuilder builder)
	{

		builder.Services.AddControllers();

		builder.Services.AddApiVersioning(config =>
		{
			config.DefaultApiVersion = new ApiVersion(1, 0);
			config.AssumeDefaultVersionWhenUnspecified = true; //if you don't specify version, use defualt
			config.ReportApiVersions = true; //if you have a couple of versions will send back supported headers in response
			config.ApiVersionReader = new UrlSegmentApiVersionReader();
		});

		builder.Services.AddVersionedApiExplorer(config =>
		{
			config.GroupNameFormat = "'v'VVV";
			config.SubstituteApiVersionInUrl = true;
		});
		builder.Services.AddEndpointsApiExplorer();
	}
}
