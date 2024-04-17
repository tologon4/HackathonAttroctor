namespace hacaton.Models;

public class Work
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string Value { get; set; }
}