namespace Social.Api.Registers;

public interface IWebApplicationBuilderRegistrar : IRegistrar
{
	void RegisterServices(WebApplicationBuilder builder);
}
