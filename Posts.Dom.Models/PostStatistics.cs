using System.Collections.Generic;
using Dom.Common;

namespace Posts.Dom.Models
{
    public class PostStatistics : ValueObject
    {
        public Dictionary<Reactions, int> ReactionCounts { get; set; }
        public int ViewsCount { get; set; }
    }
}
