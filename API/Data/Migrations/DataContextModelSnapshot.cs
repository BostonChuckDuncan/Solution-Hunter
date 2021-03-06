// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserId"), 1L, 1);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsTrialMode")
                        .HasColumnType("bit");

                    b.Property<string>("KnownAs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.Ghost", b =>
                {
                    b.Property<int>("GhostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GhostId"), 1L, 1);

                    b.Property<int>("GenerationNumber")
                        .HasColumnType("int");

                    b.Property<int>("LifeSpan")
                        .HasColumnType("int");

                    b.Property<int>("PopulationId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("GhostId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Ghosts");
                });

            modelBuilder.Entity("API.Entities.Individual", b =>
                {
                    b.Property<int>("IndividualID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IndividualID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Fitness")
                        .HasColumnType("float");

                    b.Property<int>("PopulationId")
                        .HasColumnType("int");

                    b.HasKey("IndividualID");

                    b.HasIndex("PopulationId");

                    b.ToTable("Individuals");
                });

            modelBuilder.Entity("API.Entities.Population", b =>
                {
                    b.Property<int>("PopulationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PopulationId"), 1L, 1);

                    b.Property<int>("GhostId")
                        .HasColumnType("int");

                    b.Property<int>("MaxSize")
                        .HasColumnType("int");

                    b.Property<int>("MinSize")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("PopulationId");

                    b.ToTable("Populations");
                });

            modelBuilder.Entity("API.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("API.Entities.Ghost", b =>
                {
                    b.HasOne("API.Entities.Project", "parentProject")
                        .WithMany("Ghosts")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("parentProject");
                });

            modelBuilder.Entity("API.Entities.Individual", b =>
                {
                    b.HasOne("API.Entities.Population", "OwnerPopulation")
                        .WithMany("Individuals")
                        .HasForeignKey("PopulationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OwnerPopulation");
                });

            modelBuilder.Entity("API.Entities.Project", b =>
                {
                    b.HasOne("API.Entities.AppUser", "ProjectOwner")
                        .WithMany("Projects")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectOwner");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("API.Entities.Population", b =>
                {
                    b.Navigation("Individuals");
                });

            modelBuilder.Entity("API.Entities.Project", b =>
                {
                    b.Navigation("Ghosts");
                });
#pragma warning restore 612, 618
        }
    }
}
