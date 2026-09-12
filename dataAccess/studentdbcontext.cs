using Microsoft.EntityFrameworkCore;
using Student_System.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.dataAccess
{
   public class studentdbcontext:DbContext
    {
       public DbSet<student> students { get; set; }
        public DbSet<course> courses { get; set; }
        public DbSet<resourse> resourses { get; set; }
        public DbSet<homework> homeworks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; initial catalog = student_system ; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<homework>()
                .HasOne(h => h.student)
                .WithMany()
                .HasForeignKey(h => h.studentid)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
