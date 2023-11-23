namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
