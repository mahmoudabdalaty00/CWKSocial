
using CWKSocail.Api.Options;

namespace CWKSocail.Api.Registers
{
	public class SwaggerRegister : IWebApplicationBuilderRegister
	{
		public void RegisterServices(WebApplicationBuilder builder)
		{

			builder.Services.AddSwaggerGen();
			builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

		}
	}
}
