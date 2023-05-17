using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Social.Api.Registers;

public class SwaggerWebAppRegister : IWebApplicationRegistrar
{
	public void RegisterPipelineComponents(WebApplication app)
	{
		app.UseSwagger();
		app.UseSwaggerUI(options =>
		{
			var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

			foreach (var description in provider.ApiVersionDescriptions.Reverse())
			{
				options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
					description.ApiVersion.ToString());
			}
		});
	}
}
