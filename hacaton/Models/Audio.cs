namespace hacaton.Models;

public class Audio
{
    public int Id { get; set; }
    public string FilePath { get; set; }
    
    public int WorkId { get; set; }
    public Work Work { get; set; }
}