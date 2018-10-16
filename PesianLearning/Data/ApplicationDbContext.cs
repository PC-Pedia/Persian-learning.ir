using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;

namespace PesianLearning.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=185.55.224.206;initial catalog=finicomp_learning;user id=finicomp_mohamad.mk;password=12qw!@QW", null);
            //optionsBuilder.UseSqlServer("Server=DESKTOP-85M4BPV;DataBase=LearningDB;Trusted_Connection=True;", null);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>()
                .HasMany(m => m.Images)
                .WithOne(i => i.Course)
                .IsRequired(false)
                .HasForeignKey(i => i.CourseID);


            modelBuilder.Entity<Course>().HasIndex(m => m.CateID).HasName("Fk_Inx_Cat");
            modelBuilder.Entity<Course>().HasIndex(m => m.UserID).HasName("Fk_Inx_User");
            modelBuilder.Entity<Category>().HasIndex(a => a.Title).HasName("IX_Title");
            modelBuilder.Entity<CourseState>().HasIndex(a => a.Title).HasName("IX_Title");
            modelBuilder.Entity<CourseType>().HasIndex(a => a.Title).HasName("IX_Title");
            modelBuilder.Entity<Order>().HasIndex(a => a.UserID).HasName("IX_User");
            modelBuilder.Entity<ShopingCart>().HasIndex(a => a.CourseID).HasName("IX_ShopCourse");
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<CourseState> CourseStates { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProfSkill> profSkills { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Heding> Hedings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<GroupShoping> groupShopings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<ShopingCart> ShopingCarts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

    }
}
