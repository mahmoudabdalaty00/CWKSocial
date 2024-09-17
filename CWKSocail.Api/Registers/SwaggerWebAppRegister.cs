
using Asp.Versioning.ApiExplorer;

namespace CWKSocail.Api.Registers
{
	public class SwaggerWebAppRegister : IWebApplicationRegister
	{
		public void RegisterPipelineComponents(WebApplication app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(option =>
			 {

				 var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
				 foreach (var description in provider.ApiVersionDescriptions)
				 {
					 option.SwaggerEndpoint($"/Swagger/{description.GroupName}/Swagger.json",
						 description.ApiVersion.ToString()
						 );
				 }
			 });
		}
	}
}
