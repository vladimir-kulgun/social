using System;
using Dom.Common;

namespace Posts.Dom.Models
{
    public class Post : Entity<int>
    {
        private string _content;

        public Post(int authorId, string content)
        {
            AuthorId = authorId;
            Content = content;
            CreateAt = DateTime.UtcNow;
        }
        public int AuthorId { get; private set; }
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Content));
                }

                if (!string.IsNullOrWhiteSpace(Content))
                {
                    throw new InvalidOperationException("Cannot edit existing post");
                }

                _content = value;
            }
        }
        public PostStatistics Statistics { get; private set; }
        public DateTime CreateAt { get; private set; }
        public void SetUserReaction(int userId, Reactions reaction)
        {
            if (userId == AuthorId)
            {
                throw new InvalidOperationException("Author cannot react on post");
            }

            Events.Add(new UserReactionChanged(userId, Id, reaction));
        }
        public void AddUserView(int userId)
        {
            Events.Add(new UserViewAdded(userId));
        }
    }
}
