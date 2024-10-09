using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CWKSocial.DAl.Configuration
{
	internal class IdentityUserLoginConfig : IEntityTypeConfiguration<IdentityUserLogin<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> builder)
		{
			builder.HasKey(iul => iul.UserId);
		}
	}
}