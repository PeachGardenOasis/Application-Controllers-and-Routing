﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab5controllersandrouting.Models;

namespace lab5controllersandrouting.Migrations
{
    [DbContext(typeof(FaqsContext))]
    partial class FaqsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab5controllersandrouting.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "gen",
                            Name = "General"
                        },
                        new
                        {
                            CategoryId = "hist",
                            Name = "History"
                        });
                });

            modelBuilder.Entity("lab5controllersandrouting.Models.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TopicId");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "A general purpose object-oriented langauge that uses concise java-like syntax",
                            CategoryId = "gen",
                            Question = "What is C#?",
                            TopicId = "cs"
                        },
                        new
                        {
                            Id = 2,
                            Answer = "A general purpose scripting language that executes in web browser",
                            CategoryId = "gen",
                            Question = "What is JavaScript?",
                            TopicId = "js"
                        },
                        new
                        {
                            Id = 3,
                            Answer = "A CSS framework for creating responsive web applications",
                            CategoryId = "gen",
                            Question = "What is Booststrap?",
                            TopicId = "boot"
                        },
                        new
                        {
                            Id = 4,
                            Answer = "In 2002",
                            CategoryId = "hist",
                            Question = "When was C# released?",
                            TopicId = "cs"
                        });
                });

            modelBuilder.Entity("lab5controllersandrouting.Models.Topic", b =>
                {
                    b.Property<string>("TopicId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = "cs",
                            Name = "C#"
                        },
                        new
                        {
                            TopicId = "js",
                            Name = "JavaScript"
                        },
                        new
                        {
                            TopicId = "boot",
                            Name = "Bootstrap"
                        });
                });

            modelBuilder.Entity("lab5controllersandrouting.Models.FAQ", b =>
                {
                    b.HasOne("lab5controllersandrouting.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("lab5controllersandrouting.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");

                    b.Navigation("Category");

                    b.Navigation("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}
