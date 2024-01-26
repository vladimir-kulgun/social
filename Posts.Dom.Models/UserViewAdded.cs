using Dom.Common;

namespace Posts.Dom.Models
{
    public class UserViewAdded : DomainEvent
    {
        public UserViewAdded(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; private set; }
    }
}
