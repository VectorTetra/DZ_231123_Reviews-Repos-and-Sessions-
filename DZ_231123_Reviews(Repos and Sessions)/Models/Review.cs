namespace DZ_231123_Reviews_Repos_and_Sessions_.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        //public int UserId { get; set; }
        public User User { get; set; }
    }
}
