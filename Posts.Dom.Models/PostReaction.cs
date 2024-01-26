using Dom.Common;

namespace Posts.Dom.Models
{
    public class PostReaction : ValueObject
    {
        public PostReaction(int userId, int postId, Reactions reaction)
        {
            UserId = userId;
            PostId = postId;
            Reaction = reaction;
        }

        public int UserId { get; private set; }
        public int PostId { get; private set; }
        public Reactions Reaction { get; private set; }
    }
}
