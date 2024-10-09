
using CWKSocial.DAl.Dbcontent;
using Microsoft.EntityFrameworkCore;

namespace CWKSocail.Api.Registers
{
	public class DbRegister : IWebApplicationBuilderRegister
	{
		public void RegisterServices(WebApplicationBuilder builder)
        {
            var cs = builder.Configuration.GetConnectionString("MyConnection");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(cs));
        }
	}
}
