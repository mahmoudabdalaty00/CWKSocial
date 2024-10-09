using CWK.Domain.Aggregates.Post;
using CWK.Domain.Aggregates.UserPofile;
using CWKSocial.DAl.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CWKSocial.DAl.Dbcontent
{
	public class AppDbContext : IdentityDbContext
	{

		public AppDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<UserProfile> UserProfiles { get; set; }
		public DbSet<Post> Posts { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.ApplyConfiguration(new PostCommentConfig());
            builder.ApplyConfiguration(new PostInteractionConfig());
            builder.ApplyConfiguration(new UserProfileConfig());
            builder.ApplyConfiguration(new IdentityUserLoginConfig());
            builder.ApplyConfiguration(new IdentityUserRoleConfig());
            builder.ApplyConfiguration(new IdentityUserTokenConfig());

            //builder.ApplyConfiguration(new PostCommentConfig());
            //builder.ApplyConfiguration(new PostInteractionConfig());
            //builder.ApplyConfiguration(new UserProfileConfig());
            //builder.ApplyConfiguration(new IdentityUserLoginConfig());
            //builder.ApplyConfiguration(new IdentityUserRoleConfig());
            //builder.ApplyConfiguration(new IdentityUserTokenConfig());



            //builder.Ignore<BasicInfo>();
            //builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            //base.OnModelCreating(builder);

        }


	}
}
