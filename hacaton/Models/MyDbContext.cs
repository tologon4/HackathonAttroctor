using Microsoft.EntityFrameworkCore;

namespace hacaton.Models;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Audio> Audios { get; set; }
    public DbSet<Work> Works { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
}