//using System.Collections.Generic;
//using System.Reflection.Emit;
//using WebApplication1Test.Models;

//namespace WebApplication1Test.Data
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//        {
//        }

//        public DbSet<Master> Masters { get; set; }
//        public DbSet<Task> Tasks { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            // Настройка связи между мастерами и задачами
//            modelBuilder.Entity<Task>()
//                .HasOne(t => t.Master)
//                .WithMany(m => m.Tasks)
//                .HasForeignKey(t => t.MasterId);
//        }
//    }
//}
