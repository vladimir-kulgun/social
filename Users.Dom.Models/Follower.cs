using System.Collections.Generic;

namespace Users.Dom.Models
{
    public class Follower : User
    {
        public List<Author> Authors { get; set; }
    }
}
