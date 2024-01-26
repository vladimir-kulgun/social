using System.Collections.Generic;
using Posts.Dom.Models;

namespace Users.Dom.Models
{
    public class Author : User
    {
        public List<Post> Posts { get; set; }
    }
}
