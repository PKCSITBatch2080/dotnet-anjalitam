using Microsoft.EntityFrameworkCore;

public class CollegeManagerDb: DbContext{
    public DbSet<CollegeProgram> CollegePrograms{ get; set; }
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source= CollgeManager.db");
        //ConnectionString
    }
}