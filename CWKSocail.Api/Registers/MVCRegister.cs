
using Asp.Versioning;

namespace CWKSocail.Api.Registers
{
	public class MVCRegister : IWebApplicationBuilderRegister
	{
		public void RegisterServices(WebApplicationBuilder builder)
		{
			builder.Services.AddControllersWithViews();

			builder.Services.AddApiVersioning(config =>
			{
				config.DefaultApiVersion = new ApiVersion(1, 0);
				config.AssumeDefaultVersionWhenUnspecified = true;
				config.ReportApiVersions = true;
				config.ApiVersionReader = new UrlSegmentApiVersionReader();
			});
			builder.Services.AddApiVersioning().AddMvc().AddApiExplorer(config =>
			{
				config.GroupNameFormat = "'v'VVV";
				config.SubstituteApiVersionInUrl = true;
			});


			builder.Services.AddEndpointsApiExplorer();
		}
	}
}
