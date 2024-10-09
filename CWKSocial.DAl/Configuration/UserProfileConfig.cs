using CWK.Domain.Aggregates.UserPofile;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.DAl.Configuration
{
	internal class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
	{
		public void Configure(EntityTypeBuilder<UserProfile> builder)
		{
			builder.OwnsOne(up => up.BasicInfo);
		}
	}
}
