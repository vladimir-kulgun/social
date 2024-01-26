using Dom.Common;

namespace Users.Dom.Models
{
    public class User : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Url { get; set; }
    }
}
