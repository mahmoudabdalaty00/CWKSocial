using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CWKSocail.Api.Options
{
	public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
	{

		private readonly IApiVersionDescriptionProvider _provider;




		public void Configure(SwaggerGenOptions options)
		{
			foreach (var Des in _provider.ApiVersionDescriptions)
			{
				options.SwaggerDoc(Des.GroupName , CreateVersionInfo(Des) );
			}

		}


		private OpenApiInfo CreateVersionInfo(ApiVersionDescription description)
		{
			{
				var info = new OpenApiInfo
				{
					Title = "CWKSocial",
					Version = description.ApiVersion.ToString(),
				};

				if (description.IsDeprecated) {
					info.Description = "This Api Version Has Been Deprecated Try New Version Please Or Contactedd With Our SupportServes";
				}

				return info;
			}
		}
	}
}