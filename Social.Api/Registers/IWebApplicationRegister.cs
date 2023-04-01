namespace Social.Api.Registers;

public interface IWebApplicationRegistrar : IRegistrar
{
	public void RegisterPipelineComponents(WebApplication app);
}