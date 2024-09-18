using CWK.Domain.Aggregates.UserPofile;

namespace CWK.Domain.Aggregates.Post
{
	public class Post
	{


		private readonly List<PostComment> _comment = new List<PostComment>();	
		private readonly List<PostInteraction> _interaction = new List<PostInteraction>();	


		private Post()
		{
			 
		}

		public Guid PostId { get; private set; }
		public Guid UserProfileId { get; private set; }
		public UserProfile userProfile { get; private set; }
		public string TextContent { get; private set; }
		public DateTime CreatedDate { get; private set; }
		public DateTime LastModified { get; private set; }
		public IEnumerable<PostComment> Comments { get { return _comment; } }
		public IEnumerable<PostInteraction> Interactions { get { return _interaction; } }



		public static Post CreatePost(Guid userProfileId, string textContent)
		{
			var post = new Post
			{
				UserProfileId = userProfileId,
				TextContent = textContent,
				CreatedDate = DateTime.UtcNow,
				LastModified = DateTime.UtcNow,
			};

			return post;
		}

		public void UpdatePostText(string newtext)
		{
			TextContent = newtext;
			LastModified = DateTime.UtcNow;
		}

		public void AddPostComment(PostComment newcomment)
		{
			_comment.Add(newcomment);	
		}

		public void RemovePostComment(PostComment newcomment)
		{
			_comment.Remove(newcomment);
		}
 		public void AddPostInteraction(PostInteraction newinteraction)
		{
			_interaction.Add(newinteraction);	
		}
		 
		public void RemovePosInteraction(PostInteraction newinteraction)
		{
			_interaction.Remove(newinteraction);
		}
		
		 
          



	}
}
