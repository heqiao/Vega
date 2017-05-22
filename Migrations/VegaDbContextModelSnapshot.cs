using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    partial class VegaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vega.Entities.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ModelId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Feature");
                });

            modelBuilder.Entity("Vega.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Make");
                });

            modelBuilder.Entity("Vega.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MakeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("Vega.Entities.Feature", b =>
                {
                    b.HasOne("Vega.Entities.Model")
                        .WithMany("Features")
                        .HasForeignKey("ModelId");
                });

            modelBuilder.Entity("Vega.Entities.Model", b =>
                {
                    b.HasOne("Vega.Entities.Make", "Make")
                        .WithMany()
                        .HasForeignKey("MakeId");
                });
        }
    }
}
