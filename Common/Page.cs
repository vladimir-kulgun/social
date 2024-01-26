using System.Collections.Generic;

namespace Common
{
    public class Page<T> where T : class
    {
        public int Count { get; set; }
        public int Size { get; set; }
        public int Index { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
