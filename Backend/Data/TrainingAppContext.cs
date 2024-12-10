using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class TrainingAppContext : DbContext
{
    public TrainingAppContext(DbContextOptions<TrainingAppContext> options) : base(options)
        {
        }
    public DbSet<User> Users { get; set; }
    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<WorkoutTemplate> WorkoutTemplates { get; set; }
    public DbSet<WorkoutTemplateExercise> WorkoutTemplateExercises { get; set; }
    public DbSet<SetsAndReps> SetsAndReps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure relationships and constraints
        modelBuilder.Entity<User>()
        .HasMany(u => u.Exercises)
        .WithOne(e => e.User)
        .HasForeignKey(e => e.UserId)
        .OnDelete(DeleteBehavior.Cascade); 

    // Relationship between User and WorkoutTemplates
    modelBuilder.Entity<User>()
        .HasMany(u => u.WorkoutTemplates)
        .WithOne(w => w.User)
        .HasForeignKey(w => w.UserId)
        .OnDelete(DeleteBehavior.Cascade); 

    // Relationship between WorkoutTemplate and WorkoutTemplateExercises
    modelBuilder.Entity<WorkoutTemplate>()
        .HasMany(wt => wt.WorkoutTemplateExercises)
        .WithOne(wte => wte.WorkoutTemplate)
        .HasForeignKey(wte => wte.WorkoutTemplateId)
        .OnDelete(DeleteBehavior.NoAction); // Set to NoAction to avoid multiple cascade paths

    // Relationship between Exercise and WorkoutTemplateExercises
    modelBuilder.Entity<Exercise>()
        .HasMany(e => e.WorkoutTemplateExercises)
        .WithOne(wte => wte.Exercise)
        .HasForeignKey(wte => wte.ExerciseId)
        .OnDelete(DeleteBehavior.Cascade); 

    // Relationship between WorkoutTemplateExercise and SetsAndReps
    modelBuilder.Entity<WorkoutTemplateExercise>()
        .HasMany(wte => wte.SetsAndReps)
        .WithOne(sr => sr.WorkoutTemplateExercise)
        .HasForeignKey(sr => sr.WorkoutTemplateExerciseId)
        .OnDelete(DeleteBehavior.Cascade); 
    }
}
}