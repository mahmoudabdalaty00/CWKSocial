using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWK.Domain.Aggregates.Post
{
	public  class PostInteraction
	{

		private PostInteraction()
        {
            
        }


        public Guid PostInteractionId { get;private set; }
		public Guid PostId { get; private set; }

		public InteractionType InteractionType { get; private set; }
	 

		public static PostInteraction CreatePostInteraction(Guid postid ,InteractionType type )
		{
			var interaction = new PostInteraction
			{
				PostId = postid,
				InteractionType = type,
			};
			return interaction;
		}

	}
}
