
namespace CWKSocail.Api.Registers
{
	public class MvcWebAppRegister : IWebApplicationRegister
	{
		void IWebApplicationRegister.RegisterPipelineComponents(WebApplication app)
		{

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapControllers();

		}
	}
}
