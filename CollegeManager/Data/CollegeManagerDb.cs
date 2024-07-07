using Microsoft.EntityFrameworkCore;

public class CollegeManagerDb: DbContext
{
    public DbSet<CollegeProgram> CollegePrograms { get; set; }
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=CollegeManager.db");
        // ConnectionStrings
    }
}