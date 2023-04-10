namespace DocumentUser.Models
{
    public class UserDocument
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public User User { get; set; }
        public Document Document { get; set; }
    }
}
