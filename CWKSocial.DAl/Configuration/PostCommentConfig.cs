using CWK.Domain.Aggregates.Post;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CWKSocial.DAl.Configuration
{
	internal class PostCommentConfig : IEntityTypeConfiguration<PostComment>
	{
		public void Configure(EntityTypeBuilder<PostComment> builder)
		{
			builder.HasKey(pc => pc.CommentId);
		}
	}
}
