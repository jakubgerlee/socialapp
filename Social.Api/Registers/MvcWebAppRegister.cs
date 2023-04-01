namespace Social.Api.Registers;

public class MvcWebAppRegister : IWebApplicationRegistrar
{
	public void RegisterPipelineComponents(WebApplication app)
	{
		app.UseHttpsRedirection();

		app.UseAuthorization();

		app.MapControllers();
	}
}
