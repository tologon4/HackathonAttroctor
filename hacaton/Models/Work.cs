namespace hacaton.Models;

public class Work
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public int Like { get; set; }
    public int Dislike { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int CommentId { get; set; }
    public Comment Comment { get; set; }
    
}