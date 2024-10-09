using System.ComponentModel.DataAnnotations;

namespace CWK.Domain.Aggregates.Post
{
	public class PostComment
	{

		private PostComment()
        {
            
        }

		 
        public Guid CommentId { get; private set; }
		public Guid PostId { get; private set; }
		public Guid UserProfileId { get; private set; }
		public string Text { get; private set; }
		public DateTime DateCreated { get; private set; }
		public DateTime LastModified { get; private set; }



		//factory method
		public static PostComment CreatePostComment(Guid postId, string text, Guid UserId)
		{
			var postcomment = new PostComment
			{
				PostId = postId,
				Text = text,
				UserProfileId = UserId,
				DateCreated = DateTime.UtcNow,
				LastModified = DateTime.UtcNow,

			};

			return postcomment;
		}

		public void UpdateCommentText(string text)
		{
			Text = text;
			LastModified = DateTime.UtcNow;

		}


	}
}
