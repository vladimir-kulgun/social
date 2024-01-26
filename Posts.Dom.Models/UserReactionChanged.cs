using Dom.Common;

namespace Posts.Dom.Models
{
    public class UserReactionChanged : DomainEvent
    {
        public UserReactionChanged(int userId, int postId, Reactions reaction)
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
