namespace CWKSocail.Api.Registers
{
	public interface IWebApplicationBuilderRegister : IRegister
	{
		void RegisterServices(WebApplicationBuilder builder);
	}
}
