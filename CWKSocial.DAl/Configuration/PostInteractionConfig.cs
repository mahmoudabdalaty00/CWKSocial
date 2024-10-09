using CWK.Domain.Aggregates.Post;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWKSocial.DAl.Configuration
{
	internal class PostInteractionConfig : IEntityTypeConfiguration<PostInteraction>
	{
		public void Configure(EntityTypeBuilder<PostInteraction> builder)
		{
			builder.HasKey(pi => pi.PostInteractionId);
		}
	}
}
