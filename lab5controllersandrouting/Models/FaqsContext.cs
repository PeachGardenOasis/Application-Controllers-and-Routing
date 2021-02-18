using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5controllersandrouting.Models
{
    public class FaqsContext : DbContext
    {
        public FaqsContext(DbContextOptions<FaqsContext> options)
            : base(options) { }

        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "cs", Name = "C#" },
                new Topic { TopicId = "js", Name = "JavaScript" },
                new Topic { TopicId = "boot", Name = "Bootstrap" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "gen", Name = "General" },
                new Category { CategoryId = "hist", Name = "History" }
                );
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    Id = 1,
                    Question = "What is C#?",
                    Answer = "A general purpose object-oriented langauge that uses concise java-like syntax",
                    TopicId = "cs",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 2,
                    Question = "What is JavaScript?",
                    Answer = "A general purpose scripting language that executes in web browser",
                    TopicId = "js",
                    CategoryId = "gen"
                }, 
                new FAQ
                {
                    Id = 3,
                    Question = "What is Booststrap?",
                    Answer = "A CSS framework for creating responsive web applications",
                    TopicId = "boot",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    Id = 4,
                    Question = "When was C# released?",
                    Answer = "In 2002",
                    TopicId = "cs",
                    CategoryId = "hist"
                }
                );
        }
    }
}
