using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Data
{
    public class PctoDbContext(DbContextOptions<PctoDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasIndex(x => x.FiscalCode).IsUnique();
            var classi = new List<ClassRoom>()
            {
                new()
                {
                    ClassRoomId = 1,
                    Description = "1A"
                },new()
                {
                    ClassRoomId = 2,
                    Description = "2A"
                },new()
                {
                    ClassRoomId = 3,
                    Description = "3A"
                },new()
                {
                    ClassRoomId = 4,
                    Description = "4A"
                }
            };

            var studenti = new List<Student>()
            {
                new()
                {
                    StudentId = 1,
                    Name = "A",
                    Surname = "A",
                    ClassRoomId = 1
                },new()
                {
                    StudentId = 2,
                    Name = "B",
                    Surname = "B",
                    ClassRoomId = 2
                },new()
                {
                    StudentId = 3,
                    Name = "C",
                    Surname = "C",
                    ClassRoomId = 3
                },new()
                {
                    StudentId = 4,
                    Name = "D",
                    Surname = "D",
                    ClassRoomId = 4
                },new()
                {
                    StudentId = 5,
                    Name = "E",
                    Surname = "E",
                    ClassRoomId = 1
                },new()
                {
                    StudentId = 6,
                    Name = "F",
                    Surname = "F",
                    ClassRoomId = 2
                },new()
                {
                    StudentId = 7,
                    Name = "G",
                    Surname = "G",
                    ClassRoomId = 3
                },new()
                {
                    StudentId = 8,
                    Name = "H",
                    Surname = "H",
                    ClassRoomId = 4
                }
            };
            modelBuilder.Entity<ClassRoom>().HasData(classi);
            modelBuilder.Entity<Student>().HasData(studenti);
        }
    }
}
